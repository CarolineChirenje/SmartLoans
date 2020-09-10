using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartDataAccess.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AuditActions",
                columns: table => new
                {
                    AuditActionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditActions", x => x.AuditActionID);
                });

            migrationBuilder.CreateTable(
                name: "AuditEntries",
                columns: table => new
                {
                    AuditEntryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(nullable: true),
                    AuditActionID = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    AddedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditEntries", x => x.AuditEntryID);
                });

            migrationBuilder.CreateTable(
                name: "BankAccountTypes",
                columns: table => new
                {
                    BankAccountTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankAccountTypes", x => x.BankAccountTypeID);
                });

            migrationBuilder.CreateTable(
                name: "BroadCasts",
                columns: table => new
                {
                    BroadCastID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    DisplaySite = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    EffectiveFrom = table.Column<DateTime>(nullable: false),
                    EffectiveTo = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BroadCasts", x => x.BroadCastID);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    CompanyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.CompanyID);
                });

            migrationBuilder.CreateTable(
                name: "ContactTypes",
                columns: table => new
                {
                    ContactTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactTypes", x => x.ContactTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryID);
                });

            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    CurrencyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.CurrencyID);
                });

            migrationBuilder.CreateTable(
                name: "CustomSettingTypes",
                columns: table => new
                {
                    CustomSettingTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomSettingTypes", x => x.CustomSettingTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    DepartmentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.DepartmentID);
                });

            migrationBuilder.CreateTable(
                name: "DocumentFormats",
                columns: table => new
                {
                    DocumentFormatID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentFormats", x => x.DocumentFormatID);
                });

            migrationBuilder.CreateTable(
                name: "Emails",
                columns: table => new
                {
                    EmailID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    To = table.Column<string>(nullable: true),
                    From = table.Column<string>(nullable: true),
                    CC = table.Column<string>(nullable: true),
                    BCC = table.Column<string>(nullable: true),
                    Subject = table.Column<string>(nullable: true),
                    Body = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    EmailStatus = table.Column<int>(nullable: false),
                    DelaySendingUntil = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emails", x => x.EmailID);
                });

            migrationBuilder.CreateTable(
                name: "ErrorLogging",
                columns: table => new
                {
                    ErrorLogID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SourceID = table.Column<int>(nullable: false),
                    StackTrace = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true),
                    LoggedBy = table.Column<string>(nullable: true),
                    DateLogged = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ErrorLogging", x => x.ErrorLogID);
                });

            migrationBuilder.CreateTable(
                name: "FeatureFlags",
                columns: table => new
                {
                    FeatureFlagID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeatureFlags", x => x.FeatureFlagID);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    GenderID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.GenderID);
                });

            migrationBuilder.CreateTable(
                name: "MenuGroups",
                columns: table => new
                {
                    MenuGroupID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    DisplayName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CSSClass = table.Column<string>(nullable: true),
                    OrderNo = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsActiveMenu = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuGroups", x => x.MenuGroupID);
                });

            migrationBuilder.CreateTable(
                name: "PaymentStatus",
                columns: table => new
                {
                    PaymentStatusID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentStatus", x => x.PaymentStatusID);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    PermissionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.PermissionID);
                });

            migrationBuilder.CreateTable(
                name: "PriorityRanks",
                columns: table => new
                {
                    PriorityRankID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriorityRanks", x => x.PriorityRankID);
                });

            migrationBuilder.CreateTable(
                name: "ProductFrequencies",
                columns: table => new
                {
                    ProductFrequencyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductFrequencies", x => x.ProductFrequencyID);
                });

            migrationBuilder.CreateTable(
                name: "RelationshipTypes",
                columns: table => new
                {
                    RelationshipTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelationshipTypes", x => x.RelationshipTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "SystemVariableTypes",
                columns: table => new
                {
                    CustomVariableTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemVariableTypes", x => x.CustomVariableTypeID);
                });

            migrationBuilder.CreateTable(
                name: "TransactionType",
                columns: table => new
                {
                    TransactionTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionType", x => x.TransactionTypeID);
                });

            migrationBuilder.CreateTable(
                name: "UserTypes",
                columns: table => new
                {
                    UserTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTypes", x => x.UserTypeID);
                });

            migrationBuilder.CreateTable(
                name: "WeekDays",
                columns: table => new
                {
                    WeekDayID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeekDays", x => x.WeekDayID);
                });

            migrationBuilder.CreateTable(
                name: "BankAccounts",
                columns: table => new
                {
                    BankAccountID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    BankAccountTypeID = table.Column<int>(nullable: false),
                    AccountCode = table.Column<string>(nullable: true),
                    AccountName = table.Column<string>(nullable: true),
                    AccountNumber = table.Column<string>(nullable: true),
                    CurrencyID = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankAccounts", x => x.BankAccountID);
                    table.ForeignKey(
                        name: "FK_BankAccounts_BankAccountTypes_BankAccountTypeID",
                        column: x => x.BankAccountTypeID,
                        principalTable: "BankAccountTypes",
                        principalColumn: "BankAccountTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BankAccounts_Currencies_CurrencyID",
                        column: x => x.CurrencyID,
                        principalTable: "Currencies",
                        principalColumn: "CurrencyID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Credits = table.Column<int>(nullable: false),
                    DepartmentID = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseID);
                    table.ForeignKey(
                        name: "FK_Courses_Department_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Department",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DocumentTypes",
                columns: table => new
                {
                    DocumentTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    DocumentFormatID = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentTypes", x => x.DocumentTypeID);
                    table.ForeignKey(
                        name: "FK_DocumentTypes_DocumentFormats_DocumentFormatID",
                        column: x => x.DocumentFormatID,
                        principalTable: "DocumentFormats",
                        principalColumn: "DocumentFormatID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    MenuID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    MenuGroupID = table.Column<int>(nullable: false),
                    DisplayName = table.Column<string>(nullable: true),
                    ControllerName = table.Column<string>(nullable: true),
                    ActionName = table.Column<string>(nullable: true),
                    CSSClass = table.Column<string>(nullable: true),
                    OrderNo = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.MenuID);
                    table.ForeignKey(
                        name: "FK_Menus_MenuGroups_MenuGroupID",
                        column: x => x.MenuGroupID,
                        principalTable: "MenuGroups",
                        principalColumn: "MenuGroupID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NoticeBoard",
                columns: table => new
                {
                    NoticeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: false),
                    Details = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    PriorityRankID = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    SendToGuardian = table.Column<bool>(nullable: false),
                    SendToClient = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NoticeBoard", x => x.NoticeID);
                    table.ForeignKey(
                        name: "FK_NoticeBoard_PriorityRanks_PriorityRankID",
                        column: x => x.PriorityRankID,
                        principalTable: "PriorityRanks",
                        principalColumn: "PriorityRankID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    ProductCode = table.Column<string>(nullable: true),
                    ProductFrequencyID = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CompanyID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Products_Companies_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "Companies",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_ProductFrequencies_ProductFrequencyID",
                        column: x => x.ProductFrequencyID,
                        principalTable: "ProductFrequencies",
                        principalColumn: "ProductFrequencyID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RolePermissions",
                columns: table => new
                {
                    RolePermissionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    PermissionID = table.Column<int>(nullable: false),
                    RoleID = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolePermissions", x => x.RolePermissionID);
                    table.ForeignKey(
                        name: "FK_RolePermissions_Permissions_PermissionID",
                        column: x => x.PermissionID,
                        principalTable: "Permissions",
                        principalColumn: "PermissionID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolePermissions_Roles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomSettings",
                columns: table => new
                {
                    CustomSettingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CustomVariableTypeID = table.Column<int>(nullable: false),
                    CustomSettingTypeID = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomSettings", x => x.CustomSettingID);
                    table.ForeignKey(
                        name: "FK_CustomSettings_CustomSettingTypes_CustomSettingTypeID",
                        column: x => x.CustomSettingTypeID,
                        principalTable: "CustomSettingTypes",
                        principalColumn: "CustomSettingTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomSettings_SystemVariableTypes_CustomVariableTypeID",
                        column: x => x.CustomVariableTypeID,
                        principalTable: "SystemVariableTypes",
                        principalColumn: "CustomVariableTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    UserTypeID = table.Column<int>(nullable: false),
                    EmailAddress = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_Users_UserTypes_UserTypeID",
                        column: x => x.UserTypeID,
                        principalTable: "UserTypes",
                        principalColumn: "UserTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseOutlines",
                columns: table => new
                {
                    CourseOutlineID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    CourseID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Credits = table.Column<decimal>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
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

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ClientID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    AccountNumber = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    IDNumber = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: true),
                    MobileNumber = table.Column<string>(nullable: true),
                    ResidentialAddress = table.Column<string>(nullable: true),
                    RegistrationDate = table.Column<DateTime>(nullable: false),
                    GenderID = table.Column<int>(nullable: false),
                    DepartmentID = table.Column<int>(nullable: true),
                    ProductID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientID);
                    table.ForeignKey(
                        name: "FK_Clients_Department_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Department",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Clients_Genders_GenderID",
                        column: x => x.GenderID,
                        principalTable: "Genders",
                        principalColumn: "GenderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clients_Products_ProductID1",
                        column: x => x.ProductID1,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductNotes",
                columns: table => new
                {
                    ProductNoteID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: false),
                    UserTypeID = table.Column<int>(nullable: false),
                    DateUploaded = table.Column<DateTime>(nullable: false),
                    DateClosed = table.Column<DateTime>(nullable: true),
                    DueDate = table.Column<DateTime>(nullable: false),
                    UploadedBy = table.Column<string>(nullable: true),
                    ProductID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductNotes", x => x.ProductNoteID);
                    table.ForeignKey(
                        name: "FK_ProductNotes_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductNotes_UserTypes_UserTypeID",
                        column: x => x.UserTypeID,
                        principalTable: "UserTypes",
                        principalColumn: "UserTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false),
                    RoleID = table.Column<int>(nullable: false),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    UserRoleID = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserID, x.RoleID });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientBoard",
                columns: table => new
                {
                    ClientBoardID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    ClientID = table.Column<int>(nullable: false),
                    Details = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    SendToParent = table.Column<bool>(nullable: false),
                    SendToClient = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientBoard", x => x.ClientBoardID);
                    table.ForeignKey(
                        name: "FK_ClientBoard_Clients_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Clients",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientContacts",
                columns: table => new
                {
                    ClientContactID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    ClientID = table.Column<int>(nullable: false),
                    ContactTypeID = table.Column<int>(nullable: false),
                    ContactPerson = table.Column<string>(nullable: true),
                    Contact = table.Column<string>(nullable: true),
                    RelationshipTypeID = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientContacts", x => x.ClientContactID);
                    table.ForeignKey(
                        name: "FK_ClientContacts_Clients_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Clients",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientContacts_ContactTypes_ContactTypeID",
                        column: x => x.ContactTypeID,
                        principalTable: "ContactTypes",
                        principalColumn: "ContactTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientContacts_RelationshipTypes_RelationshipTypeID",
                        column: x => x.RelationshipTypeID,
                        principalTable: "RelationshipTypes",
                        principalColumn: "RelationshipTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientDependents",
                columns: table => new
                {
                    ClientDependentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    ClientID = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    IDNumber = table.Column<string>(nullable: true),
                    Occupation = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    RegistrationDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientDependents", x => x.ClientDependentID);
                    table.ForeignKey(
                        name: "FK_ClientDependents_Clients_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Clients",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientDocuments",
                columns: table => new
                {
                    ClientDocumentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    DocumentTypeID = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    DateUploaded = table.Column<DateTime>(nullable: false),
                    UploadedBy = table.Column<string>(nullable: true),
                    FileBytes = table.Column<byte[]>(nullable: true),
                    FileType = table.Column<string>(nullable: true),
                    FileName = table.Column<string>(nullable: true),
                    ClientID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientDocuments", x => x.ClientDocumentID);
                    table.ForeignKey(
                        name: "FK_ClientDocuments_Clients_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Clients",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientDocuments_DocumentTypes_DocumentTypeID",
                        column: x => x.DocumentTypeID,
                        principalTable: "DocumentTypes",
                        principalColumn: "DocumentTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientGuarantors",
                columns: table => new
                {
                    ClientGuarantorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    ClientID = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    IDNumber = table.Column<string>(nullable: false),
                    IsMainGuarantor = table.Column<bool>(nullable: false),
                    EmailAddress = table.Column<string>(nullable: true),
                    MobileNumber = table.Column<string>(nullable: true),
                    PhysicalAddress = table.Column<string>(nullable: false)
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

            migrationBuilder.CreateTable(
                name: "ClientMedicalDetails",
                columns: table => new
                {
                    ClientMedicalID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    ClientID = table.Column<int>(nullable: false),
                    Doctor = table.Column<string>(nullable: true),
                    Telephone = table.Column<string>(nullable: true),
                    MedicalAid = table.Column<string>(nullable: true),
                    MedicalAidNo = table.Column<string>(nullable: true),
                    Allergies = table.Column<string>(nullable: true),
                    Other = table.Column<string>(nullable: true),
                    Hospital = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientMedicalDetails", x => x.ClientMedicalID);
                    table.ForeignKey(
                        name: "FK_ClientMedicalDetails_Clients_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Clients",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientNotes",
                columns: table => new
                {
                    ClientNoteID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: false),
                    UserTypeID = table.Column<int>(nullable: false),
                    DateUploaded = table.Column<DateTime>(nullable: false),
                    DateClosed = table.Column<DateTime>(nullable: true),
                    DueDate = table.Column<DateTime>(nullable: false),
                    UploadedBy = table.Column<string>(nullable: true),
                    ClientID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientNotes", x => x.ClientNoteID);
                    table.ForeignKey(
                        name: "FK_ClientNotes_Clients_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Clients",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientNotes_UserTypes_UserTypeID",
                        column: x => x.UserTypeID,
                        principalTable: "UserTypes",
                        principalColumn: "UserTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    TransactionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangedDate = table.Column<DateTime>(nullable: false),
                    LastChangedBy = table.Column<string>(nullable: true),
                    TransRef = table.Column<string>(nullable: true),
                    ClientID = table.Column<int>(nullable: false),
                    ProductID = table.Column<int>(nullable: false),
                    BankAccountID = table.Column<int>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Month = table.Column<int>(nullable: false),
                    TransactionTypeID = table.Column<int>(nullable: false),
                    TransactionTypesTransactionTypeID = table.Column<int>(nullable: true),
                    PaymentStatusID = table.Column<int>(nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmountExclVAT = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VAT = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentDate = table.Column<DateTime>(nullable: false),
                    TransactionDate = table.Column<DateTime>(nullable: false),
                    ParentPaymentID = table.Column<int>(nullable: true),
                    Reason = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.TransactionID);
                    table.ForeignKey(
                        name: "FK_Transactions_BankAccounts_BankAccountID",
                        column: x => x.BankAccountID,
                        principalTable: "BankAccounts",
                        principalColumn: "BankAccountID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transactions_Clients_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Clients",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transactions_PaymentStatus_PaymentStatusID",
                        column: x => x.PaymentStatusID,
                        principalTable: "PaymentStatus",
                        principalColumn: "PaymentStatusID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transactions_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transactions_TransactionType_TransactionTypesTransactionTypeID",
                        column: x => x.TransactionTypesTransactionTypeID,
                        principalTable: "TransactionType",
                        principalColumn: "TransactionTypeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "BankAccountTypes",
                columns: new[] { "BankAccountTypeID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 1, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 497, DateTimeKind.Local).AddTicks(7188), "Savings" },
                    { 2, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 497, DateTimeKind.Local).AddTicks(8487), "Cheque" },
                    { 3, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 497, DateTimeKind.Local).AddTicks(8507), "Credit" },
                    { 4, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 497, DateTimeKind.Local).AddTicks(8514), "Cash" }
                });

            migrationBuilder.InsertData(
                table: "ContactTypes",
                columns: new[] { "ContactTypeID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 4, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 517, DateTimeKind.Local).AddTicks(3976), "Cell Phone" },
                    { 3, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 517, DateTimeKind.Local).AddTicks(4333), "Email Address" },
                    { 2, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 517, DateTimeKind.Local).AddTicks(4342), "Postal Address" },
                    { 1, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 517, DateTimeKind.Local).AddTicks(4353), "Residential Address" },
                    { 5, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 517, DateTimeKind.Local).AddTicks(4359), "Telephone" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 156, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4801), "Norway" },
                    { 155, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4796), "N Mariana Islands" },
                    { 154, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4790), "Nigeria" },
                    { 153, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4785), "Niger" },
                    { 152, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4780), "Nicaragua" },
                    { 147, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4754), "Nepal" },
                    { 149, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4764), "Netherlands Antilles" },
                    { 148, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4759), "Netherlands" },
                    { 157, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4805), "Oman" },
                    { 146, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4749), "Nauru" },
                    { 151, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4776), "New Zealand" },
                    { 158, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4810), "Pakistan" },
                    { 162, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4830), "Paraguay" },
                    { 160, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4820), "Panama" },
                    { 161, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4825), "Papua New Guinea" },
                    { 145, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4745), "Namibia" },
                    { 163, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4834), "Peru" },
                    { 164, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4839), "Philippines" },
                    { 165, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4844), "Poland" },
                    { 166, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4849), "Portugal" },
                    { 167, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4854), "Puerto Rico" },
                    { 168, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4859), "Qatar" },
                    { 169, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4863), "Reunion" },
                    { 170, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4868), "Romania" },
                    { 159, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4815), "Palau" },
                    { 144, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4740), "Mozambique" },
                    { 139, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4717), "Moldova" },
                    { 142, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4730), "Montserrat" },
                    { 117, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4555), "Lebanon" },
                    { 118, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4559), "Lesotho" },
                    { 119, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4564), "Liberia" },
                    { 120, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4568), "Libya" },
                    { 121, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4573), "Liechtenstein" },
                    { 122, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4578), "Lithuania" },
                    { 123, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4583), "Luxembourg" },
                    { 124, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4587), "Macau" },
                    { 125, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4592), "Macedonia" },
                    { 126, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4597), "Madagascar" },
                    { 127, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4601), "Malawi" },
                    { 128, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4606), "Malaysia" },
                    { 129, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4611), "Maldives" },
                    { 130, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4672), "Mali" },
                    { 131, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4677), "Malta" },
                    { 132, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4682), "Marshall Islands" },
                    { 133, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4687), "Martinique" },
                    { 134, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4692), "Mauritania" },
                    { 135, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4696), "Mauritius" },
                    { 136, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4701), "Mayotte" },
                    { 137, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4705), "Mexico" },
                    { 138, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4712), "Micronesia Fed St" },
                    { 171, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4872), "Russia" },
                    { 140, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4721), "Monaco" },
                    { 141, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4726), "Mongolia" },
                    { 143, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4735), "Morocco" },
                    { 172, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4877), "Rwanda" },
                    { 177, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4907), "Saint Vincent and the Grenadines" },
                    { 174, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4888), "Saint Kitts Nevis" },
                    { 204, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(5095), "Togo" },
                    { 205, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(5100), "Tonga" },
                    { 206, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(5105), "Trinidad Tobago" },
                    { 207, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(5110), "Tunisia" },
                    { 208, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(5114), "Turkey" },
                    { 209, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(5119), "Turkmenistan" },
                    { 210, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(5125), "Turks Caicos Is" },
                    { 211, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(5130), "Tuvalu" },
                    { 212, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(5134), "Uganda" },
                    { 213, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(5139), "Ukraine" },
                    { 214, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(5144), "United Arab Emirates" },
                    { 215, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(5150), "United Kingdom" },
                    { 216, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(5155), "United States" },
                    { 217, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(5160), "Uruguay" },
                    { 218, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(5165), "Uzbekistan" },
                    { 219, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(5169), "Vanuatu" },
                    { 220, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(5174), "Venezuela" },
                    { 221, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(5178), "Vietnam" },
                    { 222, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(5184), "Virgin Islands" },
                    { 223, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(5189), "Wallis Futuna" },
                    { 224, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(5195), "West Bank" },
                    { 225, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(5200), "Western Sahara" },
                    { 226, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(5205), "Yemen" },
                    { 227, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(5209), "Zambia" },
                    { 228, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(5214), "Zimbabwe" },
                    { 203, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(5091), "Thailand" },
                    { 173, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4883), "Saint Helena" },
                    { 202, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(5086), "Tanzania" },
                    { 200, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(5076), "Taiwan" },
                    { 175, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4894), "Saint Lucia" },
                    { 176, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4900), "St Pierre Miquelon" },
                    { 116, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4550), "Latvia" },
                    { 178, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4911), "Samoa" },
                    { 179, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4917), "San Marino" },
                    { 180, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4923), "Sao Tome Principe" },
                    { 181, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4928), "Saudi Arabia" },
                    { 182, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4933), "Senegal" },
                    { 183, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4938), "Serbia" },
                    { 184, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4942), "Seychelles" },
                    { 185, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4947), "Sierra Leone" },
                    { 186, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(5008), "Singapore" },
                    { 187, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(5013), "Slovakia" },
                    { 188, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(5018), "Slovenia" },
                    { 189, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(5024), "Solomon Islands" },
                    { 190, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(5029), "Somalia" },
                    { 191, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(5034), "South Africa" },
                    { 192, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(5038), "Spain" },
                    { 193, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(5044), "Sri Lanka" },
                    { 194, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(5048), "Sudan" },
                    { 195, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(5053), "Suriname" },
                    { 196, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(5057), "Swaziland" },
                    { 197, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(5062), "Sweden" },
                    { 198, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(5067), "Switzerland" },
                    { 199, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(5072), "Syria" },
                    { 201, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(5081), "Tajikistan" },
                    { 115, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4545), "Laos" },
                    { 150, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4770), "New Caledonia" },
                    { 113, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4536), "Kuwait" },
                    { 30, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4065), "British Virgin Is" },
                    { 31, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4070), "Brunei" },
                    { 32, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4075), "Bulgaria" },
                    { 33, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4080), "Burkina Faso" },
                    { 34, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4088), "Burma" },
                    { 35, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4092), "Burundi" },
                    { 36, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4097), "Cambodia" },
                    { 37, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4101), "Cameroon" },
                    { 38, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4106), "Canada" },
                    { 39, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4111), "Cape Verde" },
                    { 40, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4117), "Cayman Islands" },
                    { 41, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4123), "Central African Rep" },
                    { 42, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4128), "Chad" },
                    { 43, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4133), "Chile" },
                    { 44, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4138), "China" },
                    { 45, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4142), "Colombia" },
                    { 46, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4147), "Comoros" },
                    { 47, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4153), "Congo Dem Rep" },
                    { 48, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4159), "Congo Repub of the" },
                    { 49, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4165), "Cook Islands" },
                    { 50, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4171), "Costa Rica" },
                    { 51, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4176), "Cote dIvoire" },
                    { 52, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4180), "Croatia" },
                    { 53, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4185), "Cuba" },
                    { 54, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4189), "Cyprus" },
                    { 29, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4058), "Brazil" },
                    { 55, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4195), "Czech Republic" },
                    { 28, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4053), "Botswana" },
                    { 26, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4043), "Bolivia" },
                    { 1, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(2930), "Afghanistan" },
                    { 2, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(3808), "Albania" },
                    { 3, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(3816), "Algeria" },
                    { 4, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(3829), "American Samoa" },
                    { 5, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(3834), "Andorra" },
                    { 6, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(3849), "Angola" },
                    { 7, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(3854), "Anguilla" },
                    { 8, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(3860), "Antigua Barbuda" },
                    { 9, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(3865), "Argentina" },
                    { 10, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(3872), "Armenia" },
                    { 11, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(3968), "Aruba" },
                    { 12, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(3973), "Australia" },
                    { 13, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(3977), "Austria" },
                    { 14, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(3981), "Azerbaijan" },
                    { 15, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(3986), "Bahamas" },
                    { 16, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(3992), " The" },
                    { 114, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4540), "Kyrgyzstan" },
                    { 18, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4004), "Bangladesh" },
                    { 19, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4009), "Barbados" },
                    { 20, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4014), "Belarus" },
                    { 21, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4018), "Belgium" },
                    { 22, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4023), "Belize" },
                    { 23, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4028), "Benin" },
                    { 24, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4033), "Bermuda" },
                    { 25, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4038), "Bhutan" },
                    { 27, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4049), "Bosnia Herzegovina" },
                    { 56, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4199), "Denmark" },
                    { 17, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(3996), "Bahrain" },
                    { 58, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4211), "Dominica" },
                    { 88, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4416), "Guinea" },
                    { 89, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4422), "Guinea Bissau" },
                    { 90, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4427), "Guyana" },
                    { 91, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4431), "Haiti" },
                    { 92, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4436), "Honduras" },
                    { 93, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4441), "Hong Kong" },
                    { 94, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4446), "Hungary" },
                    { 95, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4450), "Iceland" },
                    { 96, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4455), "India" },
                    { 97, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4459), "Indonesia" },
                    { 98, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4464), "Iran" },
                    { 99, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4468), "Iraq" },
                    { 100, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4473), "Ireland" },
                    { 101, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4479), "Isle of Man" },
                    { 102, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4484), "Israel" },
                    { 103, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4488), "Italy" },
                    { 105, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4497), "Japan" },
                    { 106, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4502), "Jersey" },
                    { 107, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4506), "Jordan" },
                    { 108, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4511), "Kazakhstan" },
                    { 109, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4516), "Kenya" },
                    { 110, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4520), "Kiribati" },
                    { 111, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4526), "Korea North" },
                    { 112, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4531), "Korea South" },
                    { 57, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4204), "Djibouti" },
                    { 87, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4412), "Guernsey" },
                    { 86, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4407), "Guatemala" },
                    { 104, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4493), "Jamaica" },
                    { 84, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4398), "Guadeloupe" },
                    { 59, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4218), "Dominican Republic" },
                    { 85, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4402), "Guam" },
                    { 60, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4223), "East Timor" },
                    { 61, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4228), "Ecuador" },
                    { 62, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4233), "Egypt" },
                    { 63, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4238), "El Salvador" },
                    { 65, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4249), "Eritrea" },
                    { 66, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4311), "Estonia" },
                    { 67, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4315), "Ethiopia" },
                    { 68, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4321), "Faroe Islands" },
                    { 69, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4326), "Fiji" },
                    { 70, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4330), "Finland" },
                    { 71, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4335), "France" },
                    { 64, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4244), "Equatorial Guinea" },
                    { 73, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4346), "French Polynesia" },
                    { 72, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4340), "French Guiana" },
                    { 83, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4393), "Grenada" },
                    { 81, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4384), "Greece" },
                    { 80, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4379), "Gibraltar" },
                    { 82, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4389), "Greenland" },
                    { 79, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4374), "Ghana" },
                    { 77, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4366), "Georgia" },
                    { 76, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4361), "Gaza Strip" },
                    { 75, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4356), "Gambia The" },
                    { 74, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4351), "Gabon" },
                    { 78, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 541, DateTimeKind.Local).AddTicks(4370), "Germany" }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "CurrencyID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 106, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7897), "NZD" },
                    { 107, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7903), "OMR" },
                    { 105, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7890), "NPR" },
                    { 108, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7909), "PAB" },
                    { 109, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7915), "PEN" },
                    { 110, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7923), "PGK" },
                    { 111, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7930), "PHP" },
                    { 116, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7965), "RON" },
                    { 113, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7945), "PLN" },
                    { 114, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7952), "PYG" },
                    { 115, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7958), "QAR" },
                    { 117, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7971), "RSD" },
                    { 118, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7977), "RUB" },
                    { 120, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7989), "SAR" },
                    { 104, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7884), "NOK" },
                    { 119, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7983), "RWF" },
                    { 112, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7938), "PKR" },
                    { 103, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7877), "NIO" },
                    { 90, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7582), "MKD" },
                    { 101, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7865), "NAD" },
                    { 84, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7550), "LRD" },
                    { 121, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7995), "SBD" },
                    { 85, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7555), "LSL" },
                    { 86, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7560), "LYD" },
                    { 87, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7565), "MAD" },
                    { 88, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7571), "MDL" },
                    { 89, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7576), "MGA" },
                    { 91, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7587), "MMK" },
                    { 92, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7594), "MNT" },
                    { 93, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7600), "MOP" },
                    { 94, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7824), "MRU" },
                    { 95, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7831), "MUR" },
                    { 96, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7836), "MVR" },
                    { 97, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7842), "MWK" },
                    { 98, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7847), "MXN" },
                    { 99, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7855), "MYR" },
                    { 100, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7860), "MZN" },
                    { 102, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7871), "NGN" },
                    { 122, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(8001), "SCR" },
                    { 150, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(8188), "VEF" },
                    { 124, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(8015), "SEK" },
                    { 146, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(8164), "UGX" },
                    { 147, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(8170), "USD" },
                    { 148, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(8176), "UYU" },
                    { 149, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(8182), "UZS" },
                    { 151, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(8194), "VND" },
                    { 152, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(8281), "VUV" },
                    { 153, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(8289), "WST" },
                    { 154, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(8295), "XAF" },
                    { 155, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(8301), "XCD" },
                    { 156, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(8308), "XDR" },
                    { 157, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(8317), "XOF" },
                    { 158, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(8324), "XPF" },
                    { 159, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(8331), "YER" },
                    { 160, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(8337), "ZAR" },
                    { 161, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(8343), "ZMW" },
                    { 162, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(8349), "ZWD" },
                    { 83, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7545), "LKR" },
                    { 145, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(8158), "UAH" },
                    { 123, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(8008), "SDG" },
                    { 144, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(8152), "TZS" },
                    { 142, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(8138), "TVD" },
                    { 125, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(8020), "SGD" },
                    { 126, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(8027), "SHP" },
                    { 127, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(8033), "SLL" },
                    { 128, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(8041), "SOS" },
                    { 129, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(8047), "SPL" },
                    { 130, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(8064), "SRD" },
                    { 131, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(8070), "STN" },
                    { 132, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(8077), "SVC" },
                    { 133, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(8083), "SYP" },
                    { 134, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(8089), "SZL" },
                    { 135, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(8095), "THB" },
                    { 136, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(8101), "TJS" },
                    { 137, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(8106), "TMT" },
                    { 138, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(8113), "TND" },
                    { 139, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(8119), "TOP" },
                    { 140, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(8125), "TRY" },
                    { 141, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(8131), "TTD" },
                    { 143, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(8145), "TWD" },
                    { 82, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7536), "LBP" },
                    { 24, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(6736), "BYN" },
                    { 80, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7525), "KZT" },
                    { 22, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(6723), "BTN" },
                    { 23, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(6729), "BWP" },
                    { 81, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7530), "LAK" },
                    { 25, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(6742), "BZD" },
                    { 26, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(6749), "CAD" },
                    { 27, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(6755), "CDF" },
                    { 28, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(6761), "CHF" },
                    { 21, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(6717), "BSD" },
                    { 29, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(6766), "CLP" },
                    { 31, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(6962), "COP" },
                    { 32, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(6969), "CRC" },
                    { 33, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(6974), "CUC" },
                    { 34, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(6985), "CUP" },
                    { 36, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(6997), "CZK" },
                    { 37, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7003), "DJF" },
                    { 38, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7010), "DKK" },
                    { 30, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(6949), "CNY" },
                    { 20, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(6710), "BRL" },
                    { 19, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(6704), "BOB" },
                    { 18, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(6698), "BND" },
                    { 1, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(5257), "AED" },
                    { 2, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(6554), "AFN" },
                    { 3, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(6575), "ALL" },
                    { 4, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(6583), "AMD" },
                    { 5, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(6590), "ANG" },
                    { 6, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(6616), "AOA" },
                    { 7, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(6623), "ARS" },
                    { 8, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(6629), "AUD" },
                    { 9, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(6635), "AWG" },
                    { 10, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(6647), "AZN" },
                    { 11, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(6653), "BAM" },
                    { 12, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(6660), "BBD" },
                    { 13, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(6665), "BDT" },
                    { 14, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(6672), "BGN" },
                    { 15, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(6678), "BHD" },
                    { 16, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(6684), "BIF" },
                    { 17, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(6690), "BMD" },
                    { 39, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7016), "DOP" },
                    { 40, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7021), "DZD" },
                    { 35, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(6991), "CVE" },
                    { 42, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7033), "ERN" },
                    { 63, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7405), "IMP" },
                    { 64, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7411), "INR" },
                    { 41, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7027), "EGP" },
                    { 66, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7430), "IRR" },
                    { 67, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7437), "ISK" },
                    { 68, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7443), "JEP" },
                    { 69, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7451), "JMD" },
                    { 70, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7458), "JOD" },
                    { 71, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7464), "JPY" },
                    { 72, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7470), "KES" },
                    { 73, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7478), "KGS" },
                    { 74, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7486), "KHR" },
                    { 75, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7493), "KMF" },
                    { 76, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7500), "KPW" },
                    { 77, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7506), "KRW" },
                    { 78, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7514), "KWD" },
                    { 79, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7520), "KYD" },
                    { 62, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7269), "ILS" },
                    { 61, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7137), "IDR" },
                    { 65, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7418), "IQD" },
                    { 59, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7127), "HTG" },
                    { 43, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7039), "ETB" },
                    { 44, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7045), "EUR" },
                    { 45, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7050), "FJD" },
                    { 60, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7132), "HUF" },
                    { 46, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7055), "FKP" },
                    { 47, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7061), "GBP" },
                    { 49, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7071), "GGP" },
                    { 50, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7076), "GHS" },
                    { 48, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7066), "GEL" },
                    { 52, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7087), "GMD" },
                    { 53, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7093), "GNF" },
                    { 54, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7098), "GTQ" },
                    { 55, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7105), "GYD" },
                    { 56, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7110), "HKD" },
                    { 57, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7116), "HNL" },
                    { 58, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7122), "HRK" },
                    { 51, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 505, DateTimeKind.Local).AddTicks(7082), "GIP" }
                });

            migrationBuilder.InsertData(
                table: "CustomSettingTypes",
                columns: new[] { "CustomSettingTypeID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 1, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 520, DateTimeKind.Local).AddTicks(1855), "BackEnd" },
                    { 2, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 520, DateTimeKind.Local).AddTicks(2106), "Portal" },
                    { 3, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 520, DateTimeKind.Local).AddTicks(2114), "All" },
                    { 4, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 520, DateTimeKind.Local).AddTicks(2119), "Email" }
                });

            migrationBuilder.InsertData(
                table: "DocumentFormats",
                columns: new[] { "DocumentFormatID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 3, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 550, DateTimeKind.Local).AddTicks(5406), "xlsx" },
                    { 4, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 550, DateTimeKind.Local).AddTicks(5411), "txt" },
                    { 2, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 550, DateTimeKind.Local).AddTicks(5396), "doc" },
                    { 6, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 550, DateTimeKind.Local).AddTicks(5430), "ppt" },
                    { 5, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 550, DateTimeKind.Local).AddTicks(5415), "rtf" },
                    { 1, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 550, DateTimeKind.Local).AddTicks(4426), "pdf" }
                });

            migrationBuilder.InsertData(
                table: "FeatureFlags",
                columns: new[] { "FeatureFlagID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 1, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 545, DateTimeKind.Local).AddTicks(9562), "Send Email On Error" },
                    { 2, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 546, DateTimeKind.Local).AddTicks(592), "CC Client On Error" }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "GenderID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 1, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 536, DateTimeKind.Local).AddTicks(9670), "Female" },
                    { 2, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 536, DateTimeKind.Local).AddTicks(9897), "Male" }
                });

            migrationBuilder.InsertData(
                table: "MenuGroups",
                columns: new[] { "MenuGroupID", "CSSClass", "Description", "DisplayName", "IsActive", "IsActiveMenu", "LastChangedBy", "LastChangedDate", "OrderNo" },
                values: new object[,]
                {
                    { 5, "fa fa-tools", null, "Administration", true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 559, DateTimeKind.Local).AddTicks(2351), 4 },
                    { 999, "fa fa - laptop", null, "Developer Menu", true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 559, DateTimeKind.Local).AddTicks(2395), 7 },
                    { 9998, "fa fa-university", null, "Menu", true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 559, DateTimeKind.Local).AddTicks(2374), 6 }
                });

            migrationBuilder.InsertData(
                table: "MenuGroups",
                columns: new[] { "MenuGroupID", "CSSClass", "Description", "DisplayName", "IsActive", "IsActiveMenu", "LastChangedBy", "LastChangedDate", "OrderNo" },
                values: new object[,]
                {
                    { 4, "fa fa-wrench", null, "Settings", true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 559, DateTimeKind.Local).AddTicks(2357), 5 },
                    { 3, "fa fa-money", null, "Accounting", true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 559, DateTimeKind.Local).AddTicks(2344), 3 },
                    { 1, "fa fa-umbrella", null, "DashBoard", true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 559, DateTimeKind.Local).AddTicks(1957), 1 },
                    { 2, "fa-user-circle", null, "Clients", true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 559, DateTimeKind.Local).AddTicks(2331), 2 }
                });

            migrationBuilder.InsertData(
                table: "PaymentStatus",
                columns: new[] { "PaymentStatusID", "Description", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 4, null, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 485, DateTimeKind.Local).AddTicks(1954), "Refunded" },
                    { 3, null, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 485, DateTimeKind.Local).AddTicks(1948), "Pending" },
                    { 2, null, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 485, DateTimeKind.Local).AddTicks(1927), "Reversed" },
                    { 1, null, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 485, DateTimeKind.Local).AddTicks(607), "Paid" },
                    { 5, null, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 485, DateTimeKind.Local).AddTicks(1960), "Discounted" }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "PermissionID", "Description", "IsActive", "IsDeleted", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 41, null, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 477, DateTimeKind.Local).AddTicks(3511), "Add Menu" },
                    { 34, null, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 477, DateTimeKind.Local).AddTicks(3460), "Route Enquiry" },
                    { 33, null, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 477, DateTimeKind.Local).AddTicks(3449), "Respond To Enquiry" },
                    { 31, null, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 477, DateTimeKind.Local).AddTicks(3433), "Delete Department" },
                    { 30, null, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 477, DateTimeKind.Local).AddTicks(3425), "Deactivate Department" },
                    { 29, null, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 477, DateTimeKind.Local).AddTicks(3416), "Activate Department" },
                    { 28, null, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 477, DateTimeKind.Local).AddTicks(3407), "Update Department" },
                    { 27, null, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 477, DateTimeKind.Local).AddTicks(3399), "Add Department" },
                    { 36, null, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 477, DateTimeKind.Local).AddTicks(3474), "Close Enquiry" },
                    { 37, null, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 477, DateTimeKind.Local).AddTicks(3481), "Capture Payment" },
                    { 38, null, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 477, DateTimeKind.Local).AddTicks(3488), "Refund Payment" },
                    { 39, null, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 477, DateTimeKind.Local).AddTicks(3496), "Reverse Payment" },
                    { 40, null, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 477, DateTimeKind.Local).AddTicks(3503), "Void Payment" },
                    { 35, null, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 477, DateTimeKind.Local).AddTicks(3468), "Suspend Enquiry" },
                    { 42, null, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 477, DateTimeKind.Local).AddTicks(3517), "Update Menu" },
                    { 32, null, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 477, DateTimeKind.Local).AddTicks(3441), "View Department" },
                    { 44, null, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 477, DateTimeKind.Local).AddTicks(3623), "Deactivate Menu" },
                    { 45, null, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 477, DateTimeKind.Local).AddTicks(3631), "Delete Menu" },
                    { 46, null, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 477, DateTimeKind.Local).AddTicks(3641), "View Menu" },
                    { 47, null, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 477, DateTimeKind.Local).AddTicks(3651), "Add Course" },
                    { 48, null, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 477, DateTimeKind.Local).AddTicks(3661), "Update Course" },
                    { 26, null, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 477, DateTimeKind.Local).AddTicks(3391), "View Product" },
                    { 49, null, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 477, DateTimeKind.Local).AddTicks(3669), "Delete Course" },
                    { 50, null, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 477, DateTimeKind.Local).AddTicks(3676), "View Course" },
                    { 51, null, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 477, DateTimeKind.Local).AddTicks(3685), "Update Custom Setting" },
                    { 52, null, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 477, DateTimeKind.Local).AddTicks(3692), "View Custom Setting" },
                    { 53, null, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 477, DateTimeKind.Local).AddTicks(3702), "Add Document Type" },
                    { 54, null, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 477, DateTimeKind.Local).AddTicks(3710), "Update Document Type" },
                    { 55, null, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 477, DateTimeKind.Local).AddTicks(3717), "Delete Document Type" },
                    { 56, null, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 477, DateTimeKind.Local).AddTicks(3725), "View Document Type" },
                    { 43, null, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 477, DateTimeKind.Local).AddTicks(3524), "Activate Menu" },
                    { 25, null, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 477, DateTimeKind.Local).AddTicks(3383), "Delete Product" },
                    { 20, null, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 477, DateTimeKind.Local).AddTicks(3342), "View Role" },
                    { 23, null, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 477, DateTimeKind.Local).AddTicks(3368), "Activate Product" },
                    { 1, null, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 477, DateTimeKind.Local).AddTicks(1451), "Add User" },
                    { 2, null, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 477, DateTimeKind.Local).AddTicks(2840), "Update User" },
                    { 3, null, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 477, DateTimeKind.Local).AddTicks(3165), "Activate User" },
                    { 4, null, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 477, DateTimeKind.Local).AddTicks(3180), "Deactivate User" },
                    { 5, null, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 477, DateTimeKind.Local).AddTicks(3189), "Delete User" },
                    { 24, null, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 477, DateTimeKind.Local).AddTicks(3376), "Deactivate Product" },
                    { 7, null, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 477, DateTimeKind.Local).AddTicks(3223), "Change User Password" },
                    { 8, null, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 477, DateTimeKind.Local).AddTicks(3233), "Add Client" },
                    { 9, null, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 477, DateTimeKind.Local).AddTicks(3241), "Update Client" },
                    { 10, null, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 477, DateTimeKind.Local).AddTicks(3253), "Activate Client" },
                    { 11, null, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 477, DateTimeKind.Local).AddTicks(3261), "Deactivate Client" },
                    { 6, null, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 477, DateTimeKind.Local).AddTicks(3214), "View User" },
                    { 13, null, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 477, DateTimeKind.Local).AddTicks(3277), "View Client" },
                    { 14, null, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 477, DateTimeKind.Local).AddTicks(3286), "Change Client Password" },
                    { 15, null, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 477, DateTimeKind.Local).AddTicks(3297), "Add Role" },
                    { 16, null, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 477, DateTimeKind.Local).AddTicks(3306), "Update Role" },
                    { 17, null, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 477, DateTimeKind.Local).AddTicks(3313), "Activate Role" },
                    { 18, null, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 477, DateTimeKind.Local).AddTicks(3326), "Deactivate Role" },
                    { 19, null, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 477, DateTimeKind.Local).AddTicks(3334), "Delete Role" },
                    { 21, null, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 477, DateTimeKind.Local).AddTicks(3350), "Add Product" },
                    { 22, null, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 477, DateTimeKind.Local).AddTicks(3359), "Update Product" },
                    { 12, null, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 477, DateTimeKind.Local).AddTicks(3269), "Delete Client" }
                });

            migrationBuilder.InsertData(
                table: "PriorityRanks",
                columns: new[] { "PriorityRankID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 4, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 530, DateTimeKind.Local).AddTicks(798), "Low" },
                    { 3, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 530, DateTimeKind.Local).AddTicks(792), "Medium" },
                    { 2, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 530, DateTimeKind.Local).AddTicks(785), "High" },
                    { 1, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 530, DateTimeKind.Local).AddTicks(559), "Critical" }
                });

            migrationBuilder.InsertData(
                table: "ProductFrequencies",
                columns: new[] { "ProductFrequencyID", "Description", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 5, null, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 510, DateTimeKind.Local).AddTicks(8012), "Yearly" },
                    { 4, null, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 510, DateTimeKind.Local).AddTicks(8006), "Bi Annually" },
                    { 1, null, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 510, DateTimeKind.Local).AddTicks(6803), "Weekly" },
                    { 3, null, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 510, DateTimeKind.Local).AddTicks(7989), "Quaterly" },
                    { 2, null, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 510, DateTimeKind.Local).AddTicks(7978), "Monthly" }
                });

            migrationBuilder.InsertData(
                table: "RelationshipTypes",
                columns: new[] { "RelationshipTypeID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 3, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 518, DateTimeKind.Local).AddTicks(7283), "Sibling" },
                    { 4, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 518, DateTimeKind.Local).AddTicks(7286), "Spouse" },
                    { 5, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 518, DateTimeKind.Local).AddTicks(7289), "Other" },
                    { 1, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 518, DateTimeKind.Local).AddTicks(7053), "Mother" },
                    { 2, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 518, DateTimeKind.Local).AddTicks(7278), "Father" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "Description", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[] { 1, null, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 463, DateTimeKind.Local).AddTicks(9525), "Super-Admin" });

            migrationBuilder.InsertData(
                table: "SystemVariableTypes",
                columns: new[] { "CustomVariableTypeID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 9, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 522, DateTimeKind.Local).AddTicks(4253), "Percentage" },
                    { 1, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 522, DateTimeKind.Local).AddTicks(3864), "Boolean" },
                    { 5, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 522, DateTimeKind.Local).AddTicks(4189), "Double" },
                    { 4, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 522, DateTimeKind.Local).AddTicks(4197), "Integer" },
                    { 3, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 522, DateTimeKind.Local).AddTicks(4202), "Long" },
                    { 2, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 522, DateTimeKind.Local).AddTicks(4208), "String" },
                    { 6, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 522, DateTimeKind.Local).AddTicks(4223), "Decimal" },
                    { 7, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 522, DateTimeKind.Local).AddTicks(4242), "Date Time" },
                    { 8, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 522, DateTimeKind.Local).AddTicks(4247), "Password" }
                });

            migrationBuilder.InsertData(
                table: "TransactionType",
                columns: new[] { "TransactionTypeID", "Description", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 4, null, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 491, DateTimeKind.Local).AddTicks(4576), "Void" },
                    { 5, null, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 491, DateTimeKind.Local).AddTicks(4582), "Discount" },
                    { 2, null, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 491, DateTimeKind.Local).AddTicks(4551), "Reversal" },
                    { 1, null, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 491, DateTimeKind.Local).AddTicks(3283), "Payment" },
                    { 3, null, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 491, DateTimeKind.Local).AddTicks(4570), "Refund" }
                });

            migrationBuilder.InsertData(
                table: "UserTypes",
                columns: new[] { "UserTypeID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 1, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 515, DateTimeKind.Local).AddTicks(3541), "Administrator" },
                    { 2, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 515, DateTimeKind.Local).AddTicks(4567), "Employer" },
                    { 3, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 515, DateTimeKind.Local).AddTicks(4578), "Client" },
                    { 4, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 515, DateTimeKind.Local).AddTicks(4584), "Visitor" }
                });

            migrationBuilder.InsertData(
                table: "WeekDays",
                columns: new[] { "WeekDayID", "Name" },
                values: new object[,]
                {
                    { 5, "Thursday" },
                    { 4, "Wednesday" },
                    { 6, "Friday" },
                    { 2, "Monday" },
                    { 1, "Sunday" },
                    { 3, "Tuesday" },
                    { 7, "Saturday" }
                });

            migrationBuilder.InsertData(
                table: "CustomSettings",
                columns: new[] { "CustomSettingID", "CustomSettingTypeID", "CustomVariableTypeID", "Description", "IsActive", "LastChangedBy", "LastChangedDate", "Name", "Value" },
                values: new object[,]
                {
                    { 4, 3, 1, "Allows system to BroadCast System Messages", true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 528, DateTimeKind.Local).AddTicks(3291), "BroadCast Messages", "true" },
                    { 15, 3, 9, "Percentage To Which VAT is calculated on ", true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 528, DateTimeKind.Local).AddTicks(3660), "VAT Percentage", "0.14" },
                    { 13, 4, 8, "Email Password", true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 528, DateTimeKind.Local).AddTicks(3644), "Mail Credential Password", "carochire@gmail.com" },
                    { 7, 3, 7, "Format Used to display date", true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 528, DateTimeKind.Local).AddTicks(3564), "Date Format", "yyyy-MMM-dd HH:mm" },
                    { 16, 3, 6, "Maximum file size that can be uploaded to the System", true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 528, DateTimeKind.Local).AddTicks(3671), "File Maximum UpLoadable Size", "5" },
                    { 22, 3, 2, "Foot notes that you would like to include on your statement (not mandatory)", true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 528, DateTimeKind.Local).AddTicks(3718), "Report FootNotes", "" },
                    { 21, 3, 2, "Physical Location of Logo that is to be used on Reports", true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 528, DateTimeKind.Local).AddTicks(3711), "Report Logo Path", "D:\\Dev Projects\\SmartSave\\SmartSave\\SmartResources\\SmartLogo.png" },
                    { 19, 3, 2, "First Line on the Report Footer", true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 528, DateTimeKind.Local).AddTicks(3690), "Report Footer 1", "W. Guri Mrs. (Chairman), *E. Guri (Managing)" },
                    { 18, 3, 2, "Short Name for Application", true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 528, DateTimeKind.Local).AddTicks(3682), "Application Name Prefix", "SS" },
                    { 14, 4, 2, "Display Sender Name As", true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 528, DateTimeKind.Local).AddTicks(3652), "Mail Display Name", "Smart Admin" },
                    { 12, 4, 2, "Email Address used", true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 528, DateTimeKind.Local).AddTicks(3636), "Mail Credential User Name", "carochire@gmail.com" },
                    { 20, 3, 2, "Additional Line on the Report Footer (can be blank)", true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 528, DateTimeKind.Local).AddTicks(3702), "Report Footer 2", "*Executive." },
                    { 17, 3, 2, "Account Number Prefix if Any", true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 528, DateTimeKind.Local).AddTicks(3344), "Account Number Prefix", "SS" },
                    { 9, 4, 2, "Host used to Send Emails", true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 528, DateTimeKind.Local).AddTicks(3603), "Mail SMTP Host", "" },
                    { 10, 4, 1, "Enable SSL", true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 528, DateTimeKind.Local).AddTicks(3611), "Mail Enable SSL", "true" },
                    { 11, 4, 1, "Use Default Mail Credentials", true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 528, DateTimeKind.Local).AddTicks(3625), "Mail Use Default Credentials", "true" },
                    { 23, 3, 1, "Instructs the System to Advise User to Capture VAT inclusive amounts and calculate breakdown accordingly", true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 528, DateTimeKind.Local).AddTicks(3740), "Capture VAT Inclusive Payments", "true" },
                    { 3, 3, 4, "Displays the minimum year that can be selected  from the system", true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 528, DateTimeKind.Local).AddTicks(3278), "Minimum Year", "2000" },
                    { 5, 3, 1, "Allows system to hide exceptions and show custom error page to user", true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 528, DateTimeKind.Local).AddTicks(3304), "Show Custom Exceptions To Users", "true" },
                    { 8, 4, 4, "Port used to Send Emails", true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 528, DateTimeKind.Local).AddTicks(3582), "Mail SMTP Port", "587" },
                    { 1, 3, 2, "Displayed as the Application Name", true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 528, DateTimeKind.Local).AddTicks(2613), "Application Name", "Smart Save" },
                    { 2, 3, 2, "Displays Current Version of the System", true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 528, DateTimeKind.Local).AddTicks(3264), "System Version", "1.0.0.0" },
                    { 6, 3, 4, "Limit Account Number Size", true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 528, DateTimeKind.Local).AddTicks(3332), "Account Number Length", "6" }
                });

            migrationBuilder.InsertData(
                table: "DocumentTypes",
                columns: new[] { "DocumentTypeID", "DocumentFormatID", "IsActive", "LastChangedBy", "LastChangedDate", "Name" },
                values: new object[,]
                {
                    { 1, 1, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 554, DateTimeKind.Local).AddTicks(7326), "Assignment" },
                    { 2, 1, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 554, DateTimeKind.Local).AddTicks(8804), "Birth Certificate" },
                    { 3, 1, true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 554, DateTimeKind.Local).AddTicks(8834), "Proof Of Address" }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuID", "ActionName", "CSSClass", "ControllerName", "DisplayName", "IsActive", "LastChangedBy", "LastChangedDate", "MenuGroupID", "OrderNo" },
                values: new object[,]
                {
                    { 15, "Country", "fa fa-globe", "Country", "Country", true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 562, DateTimeKind.Local).AddTicks(1051), 5, 15 },
                    { 16, "FeatureFlag", "fa fa-building", "FeatureFlag", "Feature Flags", true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 562, DateTimeKind.Local).AddTicks(1055), 999, 16 },
                    { 8, "MainMenu", "fa fa-university", "Menus", "Menu", true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 562, DateTimeKind.Local).AddTicks(1010), 9998, 8 },
                    { 12, "CustomSettings", "fa fa-spinner", "CustomSettings", "Custom Settings", true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 562, DateTimeKind.Local).AddTicks(1035), 4, 13 },
                    { 6, "Roles", "fa fa-asterisk", "Roles", "Roles & Permissions", true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 562, DateTimeKind.Local).AddTicks(995), 4, 6 },
                    { 5, "Users", "fa fa-user", "User", "Users", true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 562, DateTimeKind.Local).AddTicks(979), 4, 5 },
                    { 14, "Currency", "fa fa-money", "Currency", "Currency", true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 562, DateTimeKind.Local).AddTicks(1046), 5, 14 },
                    { 13, "BankAccounts", "fa fa-university", "BankAccounts", "Banks", true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 562, DateTimeKind.Local).AddTicks(1040), 5, 13 },
                    { 10, "NoticeBoard", "fa broadcast-tower", "NoticeBoard", "Notice Board", true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 562, DateTimeKind.Local).AddTicks(1024), 5, 10 },
                    { 9, "Courses", "fa fa-university", "Courses", "Courses", true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 562, DateTimeKind.Local).AddTicks(1015), 5, 9 },
                    { 7, "Department", "fa fa-building", "Department", "Departments", true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 562, DateTimeKind.Local).AddTicks(999), 5, 7 },
                    { 4, "Product", "fa fa-product-hunt", "Product", "Products", true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 562, DateTimeKind.Local).AddTicks(973), 3, 4 },
                    { 3, "Transactions", "fa fa-user", "Transactions", "Payments", true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 562, DateTimeKind.Local).AddTicks(966), 3, 3 },
                    { 2, "Enquiries", "fa fa-question-circle", "Enquiries", "Enquiries", true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 562, DateTimeKind.Local).AddTicks(957), 2, 2 },
                    { 1, "Clients", "fa fa-users-cog", "Client", "Clients", true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 562, DateTimeKind.Local).AddTicks(580), 2, 1 },
                    { 11, "DocumentTypes", "fa fa-file", "DocumentType", "Documents", true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 562, DateTimeKind.Local).AddTicks(1030), 5, 11 }
                });

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "RolePermissionID", "IsActive", "IsDeleted", "LastChangedBy", "LastChangedDate", "PermissionID", "RoleID" },
                values: new object[,]
                {
                    { 30, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 479, DateTimeKind.Local).AddTicks(539), 30, 1 },
                    { 40, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 479, DateTimeKind.Local).AddTicks(578), 40, 1 },
                    { 39, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 479, DateTimeKind.Local).AddTicks(575), 39, 1 },
                    { 38, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 479, DateTimeKind.Local).AddTicks(572), 38, 1 },
                    { 37, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 479, DateTimeKind.Local).AddTicks(568), 37, 1 },
                    { 33, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 479, DateTimeKind.Local).AddTicks(548), 33, 1 },
                    { 35, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 479, DateTimeKind.Local).AddTicks(562), 35, 1 },
                    { 34, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 479, DateTimeKind.Local).AddTicks(555), 34, 1 },
                    { 41, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 479, DateTimeKind.Local).AddTicks(581), 41, 1 },
                    { 32, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 479, DateTimeKind.Local).AddTicks(545), 32, 1 },
                    { 31, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 479, DateTimeKind.Local).AddTicks(542), 31, 1 },
                    { 36, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 479, DateTimeKind.Local).AddTicks(565), 36, 1 },
                    { 42, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 479, DateTimeKind.Local).AddTicks(584), 42, 1 },
                    { 47, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 479, DateTimeKind.Local).AddTicks(600), 47, 1 },
                    { 44, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 479, DateTimeKind.Local).AddTicks(590), 44, 1 },
                    { 45, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 479, DateTimeKind.Local).AddTicks(593), 45, 1 },
                    { 46, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 479, DateTimeKind.Local).AddTicks(597), 46, 1 },
                    { 48, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 479, DateTimeKind.Local).AddTicks(603), 48, 1 },
                    { 49, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 479, DateTimeKind.Local).AddTicks(606), 49, 1 },
                    { 50, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 479, DateTimeKind.Local).AddTicks(609), 50, 1 },
                    { 51, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 479, DateTimeKind.Local).AddTicks(612), 51, 1 },
                    { 52, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 479, DateTimeKind.Local).AddTicks(615), 52, 1 },
                    { 53, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 479, DateTimeKind.Local).AddTicks(618), 53, 1 },
                    { 54, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 479, DateTimeKind.Local).AddTicks(621), 54, 1 },
                    { 55, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 479, DateTimeKind.Local).AddTicks(624), 55, 1 },
                    { 56, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 479, DateTimeKind.Local).AddTicks(627), 56, 1 },
                    { 43, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 479, DateTimeKind.Local).AddTicks(587), 43, 1 },
                    { 29, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 479, DateTimeKind.Local).AddTicks(536), 29, 1 },
                    { 9, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 479, DateTimeKind.Local).AddTicks(411), 9, 1 },
                    { 27, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 479, DateTimeKind.Local).AddTicks(531), 27, 1 },
                    { 1, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 479, DateTimeKind.Local).AddTicks(58), 1, 1 },
                    { 2, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 479, DateTimeKind.Local).AddTicks(370), 2, 1 },
                    { 3, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 479, DateTimeKind.Local).AddTicks(381), 3, 1 },
                    { 4, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 479, DateTimeKind.Local).AddTicks(384), 4, 1 },
                    { 5, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 479, DateTimeKind.Local).AddTicks(387), 5, 1 },
                    { 6, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 479, DateTimeKind.Local).AddTicks(399), 6, 1 },
                    { 7, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 479, DateTimeKind.Local).AddTicks(405), 7, 1 },
                    { 8, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 479, DateTimeKind.Local).AddTicks(408), 8, 1 },
                    { 10, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 479, DateTimeKind.Local).AddTicks(416), 10, 1 },
                    { 11, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 479, DateTimeKind.Local).AddTicks(449), 11, 1 },
                    { 28, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 479, DateTimeKind.Local).AddTicks(534), 28, 1 },
                    { 13, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 479, DateTimeKind.Local).AddTicks(457), 13, 1 },
                    { 12, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 479, DateTimeKind.Local).AddTicks(452), 12, 1 },
                    { 15, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 479, DateTimeKind.Local).AddTicks(475), 15, 1 },
                    { 26, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 479, DateTimeKind.Local).AddTicks(528), 26, 1 },
                    { 25, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 479, DateTimeKind.Local).AddTicks(524), 25, 1 },
                    { 24, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 479, DateTimeKind.Local).AddTicks(521), 24, 1 },
                    { 23, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 479, DateTimeKind.Local).AddTicks(512), 23, 1 },
                    { 14, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 479, DateTimeKind.Local).AddTicks(467), 14, 1 },
                    { 21, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 479, DateTimeKind.Local).AddTicks(506), 21, 1 },
                    { 22, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 479, DateTimeKind.Local).AddTicks(509), 22, 1 },
                    { 19, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 479, DateTimeKind.Local).AddTicks(495), 19, 1 },
                    { 18, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 479, DateTimeKind.Local).AddTicks(491), 18, 1 },
                    { 17, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 479, DateTimeKind.Local).AddTicks(485), 17, 1 },
                    { 16, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 479, DateTimeKind.Local).AddTicks(482), 16, 1 },
                    { 20, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 479, DateTimeKind.Local).AddTicks(503), 20, 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "EmailAddress", "FirstName", "IsActive", "LastChangedBy", "LastChangedDate", "LastName", "Password", "UserName", "UserTypeID" },
                values: new object[,]
                {
                    { 3, "carochire@gmail.com", "Client", true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 535, DateTimeKind.Local).AddTicks(7913), "Client", "YWRtaW4=", "Client", 3 },
                    { 1, "carochire@gmail.com", "User", true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 531, DateTimeKind.Local).AddTicks(4751), "Super", "YWRtaW4=", "SuperUser", 1 },
                    { 2, "carochire@gmail.com", "Employer", true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 535, DateTimeKind.Local).AddTicks(7485), "Employer", "YWRtaW4=", "Emp1", 2 },
                    { 4, "carochire@gmail.com", "Visitor", true, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 535, DateTimeKind.Local).AddTicks(7928), "Visitor", "YWRtaW4=", "Visitor", 4 }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserID", "RoleID", "IsActive", "IsDeleted", "LastChangedBy", "LastChangedDate", "UserRoleID" },
                values: new object[] { 1, 1, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 555, DateTimeKind.Local).AddTicks(9088), 1 });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserID", "RoleID", "IsActive", "IsDeleted", "LastChangedBy", "LastChangedDate", "UserRoleID" },
                values: new object[] { 2, 1, true, false, "SuperUser", new DateTime(2020, 9, 10, 19, 5, 35, 555, DateTimeKind.Local).AddTicks(9303), 2 });

            migrationBuilder.CreateIndex(
                name: "IX_BankAccounts_BankAccountTypeID",
                table: "BankAccounts",
                column: "BankAccountTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_BankAccounts_CurrencyID",
                table: "BankAccounts",
                column: "CurrencyID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientBoard_ClientID",
                table: "ClientBoard",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientContacts_ClientID",
                table: "ClientContacts",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientContacts_ContactTypeID",
                table: "ClientContacts",
                column: "ContactTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientContacts_RelationshipTypeID",
                table: "ClientContacts",
                column: "RelationshipTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientDependents_ClientID",
                table: "ClientDependents",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientDocuments_ClientID",
                table: "ClientDocuments",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientDocuments_DocumentTypeID",
                table: "ClientDocuments",
                column: "DocumentTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientGuarantors_ClientID",
                table: "ClientGuarantors",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientMedicalDetails_ClientID",
                table: "ClientMedicalDetails",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientNotes_ClientID",
                table: "ClientNotes",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_ClientNotes_UserTypeID",
                table: "ClientNotes",
                column: "UserTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_DepartmentID",
                table: "Clients",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_GenderID",
                table: "Clients",
                column: "GenderID");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_ProductID1",
                table: "Clients",
                column: "ProductID1");

            migrationBuilder.CreateIndex(
                name: "IX_CourseOutlines_CourseID",
                table: "CourseOutlines",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_DepartmentID",
                table: "Courses",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomSettings_CustomSettingTypeID",
                table: "CustomSettings",
                column: "CustomSettingTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomSettings_CustomVariableTypeID",
                table: "CustomSettings",
                column: "CustomVariableTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentTypes_DocumentFormatID",
                table: "DocumentTypes",
                column: "DocumentFormatID");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_MenuGroupID",
                table: "Menus",
                column: "MenuGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_NoticeBoard_PriorityRankID",
                table: "NoticeBoard",
                column: "PriorityRankID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductNotes_ProductID",
                table: "ProductNotes",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductNotes_UserTypeID",
                table: "ProductNotes",
                column: "UserTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CompanyID",
                table: "Products",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductFrequencyID",
                table: "Products",
                column: "ProductFrequencyID");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermissions_PermissionID",
                table: "RolePermissions",
                column: "PermissionID");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermissions_RoleID",
                table: "RolePermissions",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_BankAccountID",
                table: "Transactions",
                column: "BankAccountID");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_ClientID",
                table: "Transactions",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_PaymentStatusID",
                table: "Transactions",
                column: "PaymentStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_ProductID",
                table: "Transactions",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_TransactionTypesTransactionTypeID",
                table: "Transactions",
                column: "TransactionTypesTransactionTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleID",
                table: "UserRoles",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserTypeID",
                table: "Users",
                column: "UserTypeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuditActions");

            migrationBuilder.DropTable(
                name: "AuditEntries");

            migrationBuilder.DropTable(
                name: "BroadCasts");

            migrationBuilder.DropTable(
                name: "ClientBoard");

            migrationBuilder.DropTable(
                name: "ClientContacts");

            migrationBuilder.DropTable(
                name: "ClientDependents");

            migrationBuilder.DropTable(
                name: "ClientDocuments");

            migrationBuilder.DropTable(
                name: "ClientGuarantors");

            migrationBuilder.DropTable(
                name: "ClientMedicalDetails");

            migrationBuilder.DropTable(
                name: "ClientNotes");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "CourseOutlines");

            migrationBuilder.DropTable(
                name: "CustomSettings");

            migrationBuilder.DropTable(
                name: "Emails");

            migrationBuilder.DropTable(
                name: "ErrorLogging");

            migrationBuilder.DropTable(
                name: "FeatureFlags");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "NoticeBoard");

            migrationBuilder.DropTable(
                name: "ProductNotes");

            migrationBuilder.DropTable(
                name: "RolePermissions");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "WeekDays");

            migrationBuilder.DropTable(
                name: "ContactTypes");

            migrationBuilder.DropTable(
                name: "RelationshipTypes");

            migrationBuilder.DropTable(
                name: "DocumentTypes");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "CustomSettingTypes");

            migrationBuilder.DropTable(
                name: "SystemVariableTypes");

            migrationBuilder.DropTable(
                name: "MenuGroups");

            migrationBuilder.DropTable(
                name: "PriorityRanks");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "BankAccounts");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "PaymentStatus");

            migrationBuilder.DropTable(
                name: "TransactionType");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "DocumentFormats");

            migrationBuilder.DropTable(
                name: "BankAccountTypes");

            migrationBuilder.DropTable(
                name: "Currencies");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "UserTypes");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "ProductFrequencies");
        }
    }
}
