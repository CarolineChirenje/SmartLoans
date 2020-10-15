﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartDataAccess.Migrations
{
    public partial class AlterTransactionAndClientFees : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientFees_ProductFees_ProductFeeID",
                table: "ClientFees");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Products_ProductID",
                table: "Transactions");

            migrationBuilder.AlterColumn<int>(
                name: "ProductID",
                table: "Transactions",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CourseID",
                table: "Transactions",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductFeeID",
                table: "ClientFees",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CourseFeeID",
                table: "ClientFees",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 772, DateTimeKind.Local).AddTicks(41));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 772, DateTimeKind.Local).AddTicks(486));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 772, DateTimeKind.Local).AddTicks(492));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 772, DateTimeKind.Local).AddTicks(496));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 782, DateTimeKind.Local).AddTicks(5276));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 782, DateTimeKind.Local).AddTicks(5269));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 782, DateTimeKind.Local).AddTicks(5258));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 782, DateTimeKind.Local).AddTicks(5132));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 782, DateTimeKind.Local).AddTicks(5282));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(2881));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3418));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3427));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3438));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3443));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3485));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3491));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3496));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3503));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3507));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3512));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3516));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3520));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3524));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3530));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3534));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3541));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3545));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3554));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3558));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3563));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3567));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3571));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3575));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3581));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3585));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3590));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3596));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3601));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3606));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3611));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3618));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3622));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3626));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3631));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3635));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3640));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3645));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3651));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3655));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3659));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3662));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3666));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3669));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3673));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3678));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3682));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3687));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3691));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3694));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3698));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3701));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3705));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3709));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3712));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3716));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3721));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3725));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3728));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3732));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3736));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3740));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3744));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3823));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3826));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3831));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3834));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3837));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3841));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3844));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3849));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3852));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3856));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3864));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3867));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3870));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3873));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3877));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3880));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3884));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3887));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3894));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3898));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3905));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3909));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3912));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3915));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3919));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3923));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3926));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3930));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3933));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3936));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3939));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3943));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3947));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3951));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3954));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3957));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3964));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3967));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3971));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3974));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3978));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3981));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3985));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3989));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3992));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(3997));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4000));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4004));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4007));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4014));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4017));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4021));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4024));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4028));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4035));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4038));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4041));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4055));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4061));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4065));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4069));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4072));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4076));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4079));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4082));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4086));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4094));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4097));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4101));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4104));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4107));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4115));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4118));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4121));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4125));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4129));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4138));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4141));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4145));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4148));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4153));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4156));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4163));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4166));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4177));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4181));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4184));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4188));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4191));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4195));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4202));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4205));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4208));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4212));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4216));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4224));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4229));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4235));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4238));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4242));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4255));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4259));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4263));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4266));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4273));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4277));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4288));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4291));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4295));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4298));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4302));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4306));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4309));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4312));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4316));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4319));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4322));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4326));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4329));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4333));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4336));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4339));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4342));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4347));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4353));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4357));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4361));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4364));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4368));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4371));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4375));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4379));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4383));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4386));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4393));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4396));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4400));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4404));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4408));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4411));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4415));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4419));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4422));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 790, DateTimeKind.Local).AddTicks(4425));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(6221));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7055));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7065));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7074));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7086));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7095));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7098));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7103));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7114));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7117));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7121));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7124));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7127));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7132));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7139));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7146));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7157));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7164));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7169));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7173));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7195));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7199));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7202));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7206));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7212));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7219));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7222));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7225));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7229));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7232));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7236));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7239));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7243));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7246));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7250));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7253));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7257));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7260));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7264));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7267));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7274));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7277));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7281));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7284));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7287));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7291));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7294));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7297));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7300));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7304));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7311));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7314));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7318));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7324));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7327));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7331));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7334));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7337));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7341));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7344));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7348));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7351));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7354));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7358));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7361));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7364));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7367));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7371));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7374));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7378));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7382));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7385));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7388));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7392));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7395));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7398));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7402));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7405));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7408));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7412));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7415));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7431));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7435));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7438));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7442));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7445));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7448));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7452));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7455));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7458));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7462));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7465));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7469));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7479));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7483));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7486));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7489));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7492));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7496));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7499));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7503));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7506));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7509));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7513));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7516));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7519));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7523));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7526));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7533));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7537));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7543));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7547));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7556));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7563));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7567));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7574));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7577));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7580));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7584));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7587));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7591));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7594));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7597));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7601));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7604));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7608));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7611));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7614));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7618));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7621));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7624));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7628));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7643));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7647));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7650));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7654));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7657));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7661));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7664));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7668));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7671));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 774, DateTimeKind.Local).AddTicks(7674));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 784, DateTimeKind.Local).AddTicks(6414));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 784, DateTimeKind.Local).AddTicks(6533));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 784, DateTimeKind.Local).AddTicks(6539));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 784, DateTimeKind.Local).AddTicks(6544));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 829, DateTimeKind.Local).AddTicks(7565));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 829, DateTimeKind.Local).AddTicks(7780));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 829, DateTimeKind.Local).AddTicks(7806));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 829, DateTimeKind.Local).AddTicks(7813));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 829, DateTimeKind.Local).AddTicks(7820));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 829, DateTimeKind.Local).AddTicks(7789));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 829, DateTimeKind.Local).AddTicks(7825));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 829, DateTimeKind.Local).AddTicks(7837));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 829, DateTimeKind.Local).AddTicks(7842));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 829, DateTimeKind.Local).AddTicks(7847));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 829, DateTimeKind.Local).AddTicks(7853));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 829, DateTimeKind.Local).AddTicks(7859));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 829, DateTimeKind.Local).AddTicks(7922));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 829, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 829, DateTimeKind.Local).AddTicks(7938));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 829, DateTimeKind.Local).AddTicks(7944));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 829, DateTimeKind.Local).AddTicks(7795));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 829, DateTimeKind.Local).AddTicks(7772));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 829, DateTimeKind.Local).AddTicks(7949));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 829, DateTimeKind.Local).AddTicks(7954));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 829, DateTimeKind.Local).AddTicks(7959));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 829, DateTimeKind.Local).AddTicks(7964));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 829, DateTimeKind.Local).AddTicks(7970));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 829, DateTimeKind.Local).AddTicks(8005));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 829, DateTimeKind.Local).AddTicks(7976));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 829, DateTimeKind.Local).AddTicks(7983));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 829, DateTimeKind.Local).AddTicks(7994));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 829, DateTimeKind.Local).AddTicks(7989));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 829, DateTimeKind.Local).AddTicks(8000));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 829, DateTimeKind.Local).AddTicks(8011));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 829, DateTimeKind.Local).AddTicks(8020));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 829, DateTimeKind.Local).AddTicks(8025));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 829, DateTimeKind.Local).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 829, DateTimeKind.Local).AddTicks(8051));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 829, DateTimeKind.Local).AddTicks(8056));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 829, DateTimeKind.Local).AddTicks(8062));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 829, DateTimeKind.Local).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 829, DateTimeKind.Local).AddTicks(8074));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 829, DateTimeKind.Local).AddTicks(8080));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 829, DateTimeKind.Local).AddTicks(8085));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 829, DateTimeKind.Local).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 829, DateTimeKind.Local).AddTicks(8097));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 829, DateTimeKind.Local).AddTicks(7832));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 802, DateTimeKind.Local).AddTicks(9015));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 802, DateTimeKind.Local).AddTicks(9506));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 802, DateTimeKind.Local).AddTicks(9515));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 802, DateTimeKind.Local).AddTicks(9520));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 802, DateTimeKind.Local).AddTicks(9525));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 802, DateTimeKind.Local).AddTicks(9536));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 807, DateTimeKind.Local).AddTicks(1338));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 807, DateTimeKind.Local).AddTicks(2920));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 807, DateTimeKind.Local).AddTicks(2967));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 807, DateTimeKind.Local).AddTicks(2974));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 824, DateTimeKind.Local).AddTicks(9725));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 823, DateTimeKind.Local).AddTicks(9574));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 824, DateTimeKind.Local).AddTicks(227));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 824, DateTimeKind.Local).AddTicks(242));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 824, DateTimeKind.Local).AddTicks(251));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 798, DateTimeKind.Local).AddTicks(9961));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 799, DateTimeKind.Local).AddTicks(825));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 799, DateTimeKind.Local).AddTicks(845));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 777, DateTimeKind.Local).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 777, DateTimeKind.Local).AddTicks(9047));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 786, DateTimeKind.Local).AddTicks(9921));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 787, DateTimeKind.Local).AddTicks(72));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 810, DateTimeKind.Local).AddTicks(9228));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                columns: new[] { "CSSClass", "LastChangedDate" },
                values: new object[] { "fa fa-users", new DateTime(2020, 10, 15, 9, 40, 22, 810, DateTimeKind.Local).AddTicks(9809) });

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 810, DateTimeKind.Local).AddTicks(9828));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 810, DateTimeKind.Local).AddTicks(9838));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 810, DateTimeKind.Local).AddTicks(9847));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 810, DateTimeKind.Local).AddTicks(9875));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 810, DateTimeKind.Local).AddTicks(9864));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                columns: new[] { "CSSClass", "LastChangedDate" },
                values: new object[] { "fa fa-users", new DateTime(2020, 10, 15, 9, 40, 22, 815, DateTimeKind.Local).AddTicks(7739) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                columns: new[] { "CSSClass", "LastChangedDate" },
                values: new object[] { "fa fa-heart", new DateTime(2020, 10, 15, 9, 40, 22, 815, DateTimeKind.Local).AddTicks(8022) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 815, DateTimeKind.Local).AddTicks(8032));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 815, DateTimeKind.Local).AddTicks(8039));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 815, DateTimeKind.Local).AddTicks(8046));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 815, DateTimeKind.Local).AddTicks(8062));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 815, DateTimeKind.Local).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                columns: new[] { "CSSClass", "LastChangedDate" },
                values: new object[] { "fa fa-users", new DateTime(2020, 10, 15, 9, 40, 22, 815, DateTimeKind.Local).AddTicks(8075) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 815, DateTimeKind.Local).AddTicks(8081));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 815, DateTimeKind.Local).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 11,
                columns: new[] { "CSSClass", "LastChangedDate" },
                values: new object[] { "fa fa-building", new DateTime(2020, 10, 15, 9, 40, 22, 815, DateTimeKind.Local).AddTicks(8098) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 815, DateTimeKind.Local).AddTicks(8104));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 815, DateTimeKind.Local).AddTicks(8111));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 815, DateTimeKind.Local).AddTicks(8118));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 815, DateTimeKind.Local).AddTicks(8124));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 815, DateTimeKind.Local).AddTicks(8131));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 815, DateTimeKind.Local).AddTicks(8141));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 815, DateTimeKind.Local).AddTicks(8151));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 815, DateTimeKind.Local).AddTicks(8156));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 815, DateTimeKind.Local).AddTicks(8162));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 815, DateTimeKind.Local).AddTicks(8168));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9999,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 815, DateTimeKind.Local).AddTicks(8175));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 765, DateTimeKind.Local).AddTicks(7870));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 765, DateTimeKind.Local).AddTicks(8743));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 765, DateTimeKind.Local).AddTicks(8753));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 765, DateTimeKind.Local).AddTicks(8759));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 765, DateTimeKind.Local).AddTicks(8763));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(2557));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3452));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3464));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3471));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3477));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3495));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3499));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3506));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3512));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3520));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3526));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3531));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3536));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3542));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3547));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3552));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3559));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3566));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3603));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3607));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3612));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3618));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3624));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3631));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3637));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3644));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3652));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3664));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3672));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3679));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3686));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3698));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3707));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3716));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3722));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3727));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3734));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3739));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3744));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3748));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3753));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3758));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3763));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3768));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3774));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3781));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3795));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3801));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3805));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3815));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3825));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3835));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3841));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3846));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3869));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3885));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3895));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3902));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3915));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3920));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3925));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3935));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3947));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3958));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3962));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3971));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3976));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3981));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3987));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(3994));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(4000));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(4005));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(4015));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(4025));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(4035));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(4041));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(4047));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(4052));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(4057));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(4063));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(4069));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(4074));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(4079));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(4084));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(4091));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(4113));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(4124));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(4129));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(4148));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(4153));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(4159));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(4169));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(4184));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(4189));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(4197));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(4205));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(4211));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(4216));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(4223));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(4228));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(4234));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(4239));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(4249));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(4255));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 760, DateTimeKind.Local).AddTicks(4261));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 791, DateTimeKind.Local).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 791, DateTimeKind.Local).AddTicks(3655));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 791, DateTimeKind.Local).AddTicks(3660));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 791, DateTimeKind.Local).AddTicks(3663));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 783, DateTimeKind.Local).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 783, DateTimeKind.Local).AddTicks(5538));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 783, DateTimeKind.Local).AddTicks(5543));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 783, DateTimeKind.Local).AddTicks(5545));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 783, DateTimeKind.Local).AddTicks(5548));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 783, DateTimeKind.Local).AddTicks(5559));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 830, DateTimeKind.Local).AddTicks(4239));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 830, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 830, DateTimeKind.Local).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 830, DateTimeKind.Local).AddTicks(4616));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 830, DateTimeKind.Local).AddTicks(4618));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 830, DateTimeKind.Local).AddTicks(4625));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 830, DateTimeKind.Local).AddTicks(4627));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 830, DateTimeKind.Local).AddTicks(4629));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 830, DateTimeKind.Local).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 830, DateTimeKind.Local).AddTicks(4634));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 830, DateTimeKind.Local).AddTicks(4636));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 830, DateTimeKind.Local).AddTicks(4637));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 830, DateTimeKind.Local).AddTicks(4639));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 830, DateTimeKind.Local).AddTicks(4641));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 830, DateTimeKind.Local).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 830, DateTimeKind.Local).AddTicks(4645));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 830, DateTimeKind.Local).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 830, DateTimeKind.Local).AddTicks(4664));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 830, DateTimeKind.Local).AddTicks(4667));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 830, DateTimeKind.Local).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 830, DateTimeKind.Local).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 830, DateTimeKind.Local).AddTicks(4672));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(6816));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7382));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7391));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7395));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7398));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7412));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7414));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7416));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7418));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7422));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7429));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7431));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7436));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7439));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7444));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7450));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7455));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7459));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7463));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7469));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7475));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7479));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7481));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7485));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7488));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7506));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7508));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7513));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7519));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7521));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7524));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7526));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7528));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7532));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7535));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7536));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7539));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7541));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7543));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7547));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7553));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7555));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7563));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7566));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7568));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7572));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7574));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7576));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7583));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7585));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7588));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7590));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7594));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7596));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7599));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7604));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7606));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7608));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7611));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7613));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7616));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7618));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7620));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7622));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7624));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7630));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7632));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7635));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7642));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7645));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7647));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7650));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7653));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7655));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7657));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7658));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7660));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7663));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7667));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7670));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7677));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7685));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7694));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7698));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7707));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7709));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7714));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7717));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7721));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7724));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7726));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7728));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7732));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7737));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7739));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7741));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7743));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7745));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7747));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7749));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7751));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7754));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7759));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7761));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7765));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7766));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7769));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7771));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7773));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7776));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7778));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 761, DateTimeKind.Local).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 753, DateTimeKind.Local).AddTicks(8663));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 755, DateTimeKind.Local).AddTicks(4583));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 755, DateTimeKind.Local).AddTicks(4667));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 786, DateTimeKind.Local).AddTicks(830));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 786, DateTimeKind.Local).AddTicks(966));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 786, DateTimeKind.Local).AddTicks(962));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 786, DateTimeKind.Local).AddTicks(958));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 786, DateTimeKind.Local).AddTicks(951));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 786, DateTimeKind.Local).AddTicks(977));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 786, DateTimeKind.Local).AddTicks(991));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 786, DateTimeKind.Local).AddTicks(995));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 786, DateTimeKind.Local).AddTicks(1001));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 769, DateTimeKind.Local).AddTicks(3079));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 769, DateTimeKind.Local).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 769, DateTimeKind.Local).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 769, DateTimeKind.Local).AddTicks(4334));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 769, DateTimeKind.Local).AddTicks(4409));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 769, DateTimeKind.Local).AddTicks(4483));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 769, DateTimeKind.Local).AddTicks(4544));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 769, DateTimeKind.Local).AddTicks(4601));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 808, DateTimeKind.Local).AddTicks(692));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 3 },
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 808, DateTimeKind.Local).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 781, DateTimeKind.Local).AddTicks(1987));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 781, DateTimeKind.Local).AddTicks(2676));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 781, DateTimeKind.Local).AddTicks(2689));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 792, DateTimeKind.Local).AddTicks(1239));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 795, DateTimeKind.Local).AddTicks(4628));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 15, 9, 40, 22, 795, DateTimeKind.Local).AddTicks(5164));

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_CourseID",
                table: "Transactions",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientFees_CourseFeeID",
                table: "ClientFees",
                column: "CourseFeeID");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientFees_CourseFees_CourseFeeID",
                table: "ClientFees",
                column: "CourseFeeID",
                principalTable: "CourseFees",
                principalColumn: "CourseFeeID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ClientFees_ProductFees_ProductFeeID",
                table: "ClientFees",
                column: "ProductFeeID",
                principalTable: "ProductFees",
                principalColumn: "ProductFeeID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Courses_CourseID",
                table: "Transactions",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "CourseID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Products_ProductID",
                table: "Transactions",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientFees_CourseFees_CourseFeeID",
                table: "ClientFees");

            migrationBuilder.DropForeignKey(
                name: "FK_ClientFees_ProductFees_ProductFeeID",
                table: "ClientFees");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Courses_CourseID",
                table: "Transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Products_ProductID",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_CourseID",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_ClientFees_CourseFeeID",
                table: "ClientFees");

            migrationBuilder.DropColumn(
                name: "CourseID",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "CourseFeeID",
                table: "ClientFees");

            migrationBuilder.AlterColumn<int>(
                name: "ProductID",
                table: "Transactions",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductFeeID",
                table: "ClientFees",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 208, DateTimeKind.Local).AddTicks(8263));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 208, DateTimeKind.Local).AddTicks(8955));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 208, DateTimeKind.Local).AddTicks(8969));

            migrationBuilder.UpdateData(
                table: "BankAccountTypes",
                keyColumn: "BankAccountTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 208, DateTimeKind.Local).AddTicks(8974));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 218, DateTimeKind.Local).AddTicks(2293));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 218, DateTimeKind.Local).AddTicks(2286));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 218, DateTimeKind.Local).AddTicks(2279));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 218, DateTimeKind.Local).AddTicks(2193));

            migrationBuilder.UpdateData(
                table: "ContactTypes",
                keyColumn: "ContactTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 218, DateTimeKind.Local).AddTicks(2297));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(7544));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8275));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8283));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8305));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8326));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8335));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8346));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8354));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8359));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8363));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8368));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8374));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8379));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8386));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8394));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8398));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8402));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8406));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8414));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8418));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8425));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8429));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8434));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8440));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8450));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8454));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8466));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8475));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8488));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8493));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8499));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8503));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8507));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8511));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8515));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8522));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8527));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8533));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8545));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8549));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8554));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8583));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8588));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8593));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8597));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8607));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8613));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8617));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8624));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8628));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8634));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8639));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8644));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8653));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8657));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8661));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8668));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8671));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8675));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8689));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8694));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8699));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8703));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8712));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8716));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8720));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8725));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8731));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8735));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8743));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8749));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8757));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8761));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8766));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8770));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8775));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8779));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8784));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8787));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8791));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8797));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8805));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8823));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8827));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8831));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8835));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8840));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8848));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8852));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8869));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8884));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8889));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8893));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8897));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8903));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8907));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8911));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8916));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8924));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8928));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8932));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8944));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8949));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8956));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8961));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8966));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8974));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8979));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8983));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8987));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8992));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(8997));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9001));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9005));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9009));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9013));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9018));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9022));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9028));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9036));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9041));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9046));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9051));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9055));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9059));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9064));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9069));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9075));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9079));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9084));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9088));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9094));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9104));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 163,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9107));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 164,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9112));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 165,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9118));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 166,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9122));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 167,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9127));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 168,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9131));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 169,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9151));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 170,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9155));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 171,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9162));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 172,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 173,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9172));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 174,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9177));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 175,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9184));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 176,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9190));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 177,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9196));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 178,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9202));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 179,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9207));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 180,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9212));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 181,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9217));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 182,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9223));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 183,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9228));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 184,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9232));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 185,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9236));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 186,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9241));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 187,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9245));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 188,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9250));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 189,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9255));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 190,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9259));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 191,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9263));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 192,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9267));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 193,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9272));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 194,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9276));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 195,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9280));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 196,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9284));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 197,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9289));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 198,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9294));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 199,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9298));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 200,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9301));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 201,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9305));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 202,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9312));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 203,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9316));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 204,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9320));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 205,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9323));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 206,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9328));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 207,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9334));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 208,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9337));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 209,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9342));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 210,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9346));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 211,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9351));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 212,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9355));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 213,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9359));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 214,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9364));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 215,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9369));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 216,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9374));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 217,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9378));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 218,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 219,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9386));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 220,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9390));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 221,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9394));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 222,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9399));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 223,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9403));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 224,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9408));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 225,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9413));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 226,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9417));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 227,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9421));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 228,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 225, DateTimeKind.Local).AddTicks(9425));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(3042));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4056));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4063));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4067));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4083));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4086));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4094));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4098));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4101));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4105));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4109));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4112));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4127));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4131));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4139));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4146));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4149));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4153));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4156));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4159));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4162));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4173));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4179));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4183));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4186));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4191));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4194));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4197));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4200));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4203));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4206));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4209));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4213));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4216));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4223));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4226));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4229));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4232));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4235));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4239));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4242));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4245));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4248));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4251));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4254));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4257));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4261));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4264));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4267));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4271));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4274));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4277));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4281));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4287));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4290));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4296));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4299));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4302));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4305));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4308));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4311));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4314));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4318));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4321));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4325));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4329));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4343));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4346));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4349));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4352));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4356));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4359));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4362));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4366));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4369));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4372));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4375));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4378));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4381));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4385));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4389));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4392));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4395));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4398));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4401));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4404));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4407));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4413));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4416));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4423));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4426));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4429));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4432));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4435));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4439));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4441));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4445));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4448));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4451));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4454));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4457));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4463));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4469));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4472));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4475));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4478));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4481));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4484));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4488));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4491));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4494));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4497));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 128,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4500));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 129,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4503));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 130,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4509));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 131,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4512));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 132,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4515));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 133,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4518));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 134,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 135,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4524));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 136,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4536));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 137,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4539));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 138,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4542));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 139,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4545));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 140,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4548));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 141,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4552));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 142,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4555));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 143,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4558));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 144,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4561));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 145,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4564));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 146,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4567));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 147,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 148,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4573));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 149,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4576));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 150,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4579));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 151,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4583));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 152,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4586));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 153,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4589));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 154,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 155,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 156,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4598));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 157,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4601));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 158,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4604));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 159,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4607));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 160,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 161,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "CurrencyID",
                keyValue: 162,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 212, DateTimeKind.Local).AddTicks(4616));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 219, DateTimeKind.Local).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 219, DateTimeKind.Local).AddTicks(6376));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 219, DateTimeKind.Local).AddTicks(6381));

            migrationBuilder.UpdateData(
                table: "CustomSettingTypes",
                keyColumn: "CustomSettingTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 219, DateTimeKind.Local).AddTicks(6385));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 252, DateTimeKind.Local).AddTicks(8442));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 252, DateTimeKind.Local).AddTicks(8616));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 252, DateTimeKind.Local).AddTicks(8635));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 252, DateTimeKind.Local).AddTicks(8644));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 252, DateTimeKind.Local).AddTicks(8649));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 252, DateTimeKind.Local).AddTicks(8622));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 252, DateTimeKind.Local).AddTicks(8654));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 252, DateTimeKind.Local).AddTicks(8666));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 252, DateTimeKind.Local).AddTicks(8670));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 252, DateTimeKind.Local).AddTicks(8675));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 252, DateTimeKind.Local).AddTicks(8681));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 252, DateTimeKind.Local).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 252, DateTimeKind.Local).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 252, DateTimeKind.Local).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 252, DateTimeKind.Local).AddTicks(8753));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 252, DateTimeKind.Local).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 252, DateTimeKind.Local).AddTicks(8626));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 252, DateTimeKind.Local).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 252, DateTimeKind.Local).AddTicks(8763));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 252, DateTimeKind.Local).AddTicks(8767));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 252, DateTimeKind.Local).AddTicks(8771));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 252, DateTimeKind.Local).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 252, DateTimeKind.Local).AddTicks(8781));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 252, DateTimeKind.Local).AddTicks(8830));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 252, DateTimeKind.Local).AddTicks(8787));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 252, DateTimeKind.Local).AddTicks(8792));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 252, DateTimeKind.Local).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 252, DateTimeKind.Local).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 252, DateTimeKind.Local).AddTicks(8825));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 252, DateTimeKind.Local).AddTicks(8835));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 252, DateTimeKind.Local).AddTicks(8840));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 252, DateTimeKind.Local).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 252, DateTimeKind.Local).AddTicks(8851));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 252, DateTimeKind.Local).AddTicks(8856));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 252, DateTimeKind.Local).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 252, DateTimeKind.Local).AddTicks(8865));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 252, DateTimeKind.Local).AddTicks(8871));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 252, DateTimeKind.Local).AddTicks(8875));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 252, DateTimeKind.Local).AddTicks(8880));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 252, DateTimeKind.Local).AddTicks(8885));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 252, DateTimeKind.Local).AddTicks(8889));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 252, DateTimeKind.Local).AddTicks(8895));

            migrationBuilder.UpdateData(
                table: "CustomSettings",
                keyColumn: "CustomSettingID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 252, DateTimeKind.Local).AddTicks(8661));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 236, DateTimeKind.Local).AddTicks(5355));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 236, DateTimeKind.Local).AddTicks(5758));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 236, DateTimeKind.Local).AddTicks(5765));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 236, DateTimeKind.Local).AddTicks(5768));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 236, DateTimeKind.Local).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "DocumentFormats",
                keyColumn: "DocumentFormatID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 236, DateTimeKind.Local).AddTicks(5781));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 239, DateTimeKind.Local).AddTicks(374));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 239, DateTimeKind.Local).AddTicks(1400));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 239, DateTimeKind.Local).AddTicks(1434));

            migrationBuilder.UpdateData(
                table: "DocumentTypes",
                keyColumn: "DocumentTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 239, DateTimeKind.Local).AddTicks(1437));

            migrationBuilder.UpdateData(
                table: "EmailTemplates",
                keyColumn: "EmailTemplateID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 248, DateTimeKind.Local).AddTicks(9159));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 248, DateTimeKind.Local).AddTicks(3154));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 248, DateTimeKind.Local).AddTicks(3639));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 248, DateTimeKind.Local).AddTicks(3645));

            migrationBuilder.UpdateData(
                table: "EmailTypes",
                keyColumn: "EmailTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 248, DateTimeKind.Local).AddTicks(3650));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 233, DateTimeKind.Local).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 233, DateTimeKind.Local).AddTicks(9684));

            migrationBuilder.UpdateData(
                table: "FeatureFlags",
                keyColumn: "FeatureFlagID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 233, DateTimeKind.Local).AddTicks(9694));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 214, DateTimeKind.Local).AddTicks(9189));

            migrationBuilder.UpdateData(
                table: "Frequencies",
                keyColumn: "FrequencyID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 214, DateTimeKind.Local).AddTicks(9873));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 221, DateTimeKind.Local).AddTicks(5903));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "GenderID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 221, DateTimeKind.Local).AddTicks(6115));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 241, DateTimeKind.Local).AddTicks(919));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                columns: new[] { "CSSClass", "LastChangedDate" },
                values: new object[] { "fa fa-user", new DateTime(2020, 10, 13, 22, 7, 48, 241, DateTimeKind.Local).AddTicks(1655) });

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 241, DateTimeKind.Local).AddTicks(1668));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 241, DateTimeKind.Local).AddTicks(1675));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 241, DateTimeKind.Local).AddTicks(1681));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 999,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 241, DateTimeKind.Local).AddTicks(1699));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "MenuGroupID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 241, DateTimeKind.Local).AddTicks(1693));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 1,
                columns: new[] { "CSSClass", "LastChangedDate" },
                values: new object[] { "fa fa-users-cog", new DateTime(2020, 10, 13, 22, 7, 48, 243, DateTimeKind.Local).AddTicks(5860) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 2,
                columns: new[] { "CSSClass", "LastChangedDate" },
                values: new object[] { "fa fa-users-user", new DateTime(2020, 10, 13, 22, 7, 48, 243, DateTimeKind.Local).AddTicks(6070) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 243, DateTimeKind.Local).AddTicks(6078));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 243, DateTimeKind.Local).AddTicks(6085));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 243, DateTimeKind.Local).AddTicks(6090));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 243, DateTimeKind.Local).AddTicks(6101));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 243, DateTimeKind.Local).AddTicks(6106));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 8,
                columns: new[] { "CSSClass", "LastChangedDate" },
                values: new object[] { "fa fa-user", new DateTime(2020, 10, 13, 22, 7, 48, 243, DateTimeKind.Local).AddTicks(6112) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 243, DateTimeKind.Local).AddTicks(6115));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 243, DateTimeKind.Local).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 11,
                columns: new[] { "CSSClass", "LastChangedDate" },
                values: new object[] { "fa-building-o", new DateTime(2020, 10, 13, 22, 7, 48, 243, DateTimeKind.Local).AddTicks(6154) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 243, DateTimeKind.Local).AddTicks(6158));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 243, DateTimeKind.Local).AddTicks(6162));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 243, DateTimeKind.Local).AddTicks(6166));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 243, DateTimeKind.Local).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 243, DateTimeKind.Local).AddTicks(6174));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 243, DateTimeKind.Local).AddTicks(6177));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 243, DateTimeKind.Local).AddTicks(6182));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 243, DateTimeKind.Local).AddTicks(6185));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 243, DateTimeKind.Local).AddTicks(6189));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9998,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 243, DateTimeKind.Local).AddTicks(6192));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "MenuID",
                keyValue: 9999,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 243, DateTimeKind.Local).AddTicks(6195));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 200, DateTimeKind.Local).AddTicks(5555));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 200, DateTimeKind.Local).AddTicks(6104));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 200, DateTimeKind.Local).AddTicks(6116));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 200, DateTimeKind.Local).AddTicks(6119));

            migrationBuilder.UpdateData(
                table: "PaymentStatus",
                keyColumn: "PaymentStatusID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 200, DateTimeKind.Local).AddTicks(6123));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(1212));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(1838));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(1856));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(1863));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(1884));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(1892));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(1898));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(1903));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(1931));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(1939));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(1945));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(1951));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(1957));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(1964));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(1971));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(1976));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(1985));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(1996));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2002));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2008));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2014));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2020));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2026));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2033));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2039));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2045));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2051));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2057));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2062));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2067));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2074));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2082));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2089));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2096));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2102));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2108));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2114));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2119));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2130));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2135));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2141));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2145));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2150));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2155));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2161));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2166));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2171));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2177));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2196));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2202));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2208));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2213));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2218));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2224));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2229));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2235));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2246));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2251));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2256));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2261));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2265));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2271));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2279));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2284));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2288));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2293));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2298));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2308));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2314));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2319));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2324));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2328));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2334));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2338));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2343));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2348));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2354));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2359));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2365));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2369));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2375));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2380));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2384));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2389));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2394));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2399));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2404));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2422));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2427));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2432));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2437));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2442));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2448));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2453));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2459));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2464));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2469));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2474));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2480));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2487));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2494));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2500));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2507));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2513));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2520));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2527));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2534));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2541));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2549));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2555));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2561));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2567));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2572));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2578));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2585));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2590));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2596));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2602));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2608));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2614));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2621));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2627));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 196, DateTimeKind.Local).AddTicks(2632));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 227, DateTimeKind.Local).AddTicks(1905));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 227, DateTimeKind.Local).AddTicks(2022));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 227, DateTimeKind.Local).AddTicks(2028));

            migrationBuilder.UpdateData(
                table: "PriorityRanks",
                keyColumn: "PriorityRankID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 227, DateTimeKind.Local).AddTicks(2032));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 218, DateTimeKind.Local).AddTicks(8840));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 218, DateTimeKind.Local).AddTicks(8969));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 218, DateTimeKind.Local).AddTicks(8973));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 218, DateTimeKind.Local).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 218, DateTimeKind.Local).AddTicks(8978));

            migrationBuilder.UpdateData(
                table: "RelationshipTypes",
                keyColumn: "RelationshipTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 218, DateTimeKind.Local).AddTicks(8983));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 253, DateTimeKind.Local).AddTicks(4564));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 253, DateTimeKind.Local).AddTicks(5681));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 253, DateTimeKind.Local).AddTicks(5684));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 253, DateTimeKind.Local).AddTicks(5685));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 253, DateTimeKind.Local).AddTicks(5687));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 253, DateTimeKind.Local).AddTicks(5691));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 253, DateTimeKind.Local).AddTicks(5693));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 253, DateTimeKind.Local).AddTicks(5695));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 253, DateTimeKind.Local).AddTicks(5696));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 253, DateTimeKind.Local).AddTicks(5699));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 253, DateTimeKind.Local).AddTicks(5701));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 253, DateTimeKind.Local).AddTicks(5702));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 253, DateTimeKind.Local).AddTicks(5704));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 253, DateTimeKind.Local).AddTicks(5705));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 253, DateTimeKind.Local).AddTicks(5707));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 253, DateTimeKind.Local).AddTicks(5708));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 253, DateTimeKind.Local).AddTicks(5710));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 253, DateTimeKind.Local).AddTicks(5713));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 253, DateTimeKind.Local).AddTicks(5714));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 253, DateTimeKind.Local).AddTicks(5716));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 253, DateTimeKind.Local).AddTicks(5717));

            migrationBuilder.UpdateData(
                table: "RoleMenus",
                keyColumn: "RoleMenuID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 253, DateTimeKind.Local).AddTicks(5719));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(2921));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3602));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3611));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3614));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3617));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3625));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3628));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3631));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3634));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 10,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3652));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 11,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3655));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 12,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 13,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3660));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 14,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3663));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 15,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3665));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 16,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3668));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 17,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 18,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3676));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 19,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3679));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 20,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3682));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 21,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3684));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 22,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3687));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 23,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3689));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 24,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3692));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 25,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3695));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 26,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3697));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 27,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3700));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 28,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3703));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 29,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3705));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 30,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3708));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 31,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3710));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 32,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3713));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 33,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3716));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 34,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3721));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 35,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3723));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 36,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3726));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 37,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3729));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 38,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3731));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 39,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3733));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 40,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3735));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 41,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3737));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 42,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3739));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 43,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3741));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 44,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3743));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 45,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3745));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 46,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3747));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 47,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3749));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 48,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3751));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 49,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3753));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 50,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3755));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 51,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3757));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 52,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3759));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 53,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3761));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 54,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3763));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 55,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3765));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 56,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 57,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 58,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3771));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 59,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3774));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 60,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3776));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 61,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3779));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 62,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3781));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 63,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3783));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 64,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3785));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 65,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3787));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 66,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3791));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 67,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3793));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 68,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3795));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 69,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3797));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 70,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3799));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 71,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3801));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 72,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3803));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 73,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3805));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 74,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3808));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 75,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3809));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 76,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3812));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 77,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3814));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 78,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3816));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 79,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3819));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 80,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3821));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 81,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3823));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 82,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3825));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 83,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3827));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 84,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3829));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 85,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3831));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 86,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3833));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 87,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3835));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 88,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3837));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 89,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3839));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 90,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3842));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 91,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3844));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 92,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3846));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 93,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3849));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 94,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3851));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 95,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3853));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 96,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3856));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 97,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3858));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 98,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 99,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3862));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 100,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3864));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 101,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3866));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 102,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3868));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 103,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3871));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 104,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3873));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 105,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3875));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 106,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 107,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3894));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 108,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3896));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 109,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3898));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 110,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 111,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3903));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 112,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3906));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 113,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3908));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 114,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 115,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3913));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 116,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3915));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 117,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3918));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 118,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3920));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 119,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3922));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 120,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3925));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 121,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3927));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 122,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3929));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 123,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3932));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 124,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3934));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 125,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3936));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 126,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3938));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "RolePermissionID",
                keyValue: 127,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 197, DateTimeKind.Local).AddTicks(3941));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 188, DateTimeKind.Local).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 190, DateTimeKind.Local).AddTicks(4302));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 190, DateTimeKind.Local).AddTicks(4387));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 220, DateTimeKind.Local).AddTicks(7671));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 220, DateTimeKind.Local).AddTicks(7787));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 220, DateTimeKind.Local).AddTicks(7783));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 220, DateTimeKind.Local).AddTicks(7780));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 220, DateTimeKind.Local).AddTicks(7774));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 220, DateTimeKind.Local).AddTicks(7800));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 220, DateTimeKind.Local).AddTicks(7809));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 220, DateTimeKind.Local).AddTicks(7812));

            migrationBuilder.UpdateData(
                table: "SystemVariableTypes",
                keyColumn: "CustomVariableTypeID",
                keyValue: 9,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 220, DateTimeKind.Local).AddTicks(7816));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 205, DateTimeKind.Local).AddTicks(683));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 205, DateTimeKind.Local).AddTicks(2190));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 205, DateTimeKind.Local).AddTicks(2381));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 4,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 205, DateTimeKind.Local).AddTicks(2508));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 5,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 205, DateTimeKind.Local).AddTicks(2621));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 6,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 205, DateTimeKind.Local).AddTicks(2721));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 7,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 205, DateTimeKind.Local).AddTicks(2801));

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeID",
                keyValue: 8,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 205, DateTimeKind.Local).AddTicks(2878));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 1, 1 },
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 239, DateTimeKind.Local).AddTicks(6169));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "UserID", "RoleID" },
                keyValues: new object[] { 2, 3 },
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 239, DateTimeKind.Local).AddTicks(6247));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 217, DateTimeKind.Local).AddTicks(3286));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 217, DateTimeKind.Local).AddTicks(3699));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "UserTypeID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 217, DateTimeKind.Local).AddTicks(3708));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 228, DateTimeKind.Local).AddTicks(263));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 230, DateTimeKind.Local).AddTicks(7890));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "LastChangedDate",
                value: new DateTime(2020, 10, 13, 22, 7, 48, 230, DateTimeKind.Local).AddTicks(8688));

            migrationBuilder.AddForeignKey(
                name: "FK_ClientFees_ProductFees_ProductFeeID",
                table: "ClientFees",
                column: "ProductFeeID",
                principalTable: "ProductFees",
                principalColumn: "ProductFeeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Products_ProductID",
                table: "Transactions",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
